using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using List.Models.Abstract;
using List.Models.Entities;

namespace List.Models.Concrete {
    public class ConcInpInfoRepository : IInputInfoRepository {

        private InputInfoContext inpInfoCont = new InputInfoContext();
        public IQueryable<InputInfo> InputInfoes {
            get {
                return inpInfoCont.InputInfoes;
            }
        }

        public void AddInfo(InputInfo inputInfo) {
            if (inputInfo.Text != null && inputInfo.Text != "") {
                inpInfoCont.InputInfoes.Add(inputInfo);
                inpInfoCont.SaveChanges();
            }
        }

        public InputInfo DeleteInfo(int inputInfoId) {
            InputInfo dbEntry = inpInfoCont.InputInfoes.Find(inputInfoId);
            if (dbEntry != null) {
                inpInfoCont.InputInfoes.Remove(dbEntry);
                inpInfoCont.SaveChanges();
            }
            return dbEntry;
        }
    }
}

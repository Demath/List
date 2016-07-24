using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using List.Models.Entities;

namespace List.Models.Abstract {
    public interface IInputInfoRepository {

        IQueryable<InputInfo> InputInfoes { get; }

        void AddInfo(InputInfo inputInfo);

        InputInfo DeleteInfo(int inputInfoId);
    }
}

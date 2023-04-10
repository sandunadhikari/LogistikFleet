using System;
using System.Collections.Generic;
using System.Text;

namespace LogistikFleetModel
{
    public class AddChecklistMobileRequest
    {
        public int AgreementId { get; set; }

        public int AnswerId { get; set; }

        public List<DefaultDamageList> DefaultDamageChecklistIn { get; set; }

        public List<DefaultDamageList> DefaultDamageChecklistout { get; set; }


    }
}

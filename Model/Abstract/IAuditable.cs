using System;

namespace Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }

        string CreatedBy { set; get; }

        DateTime? UpdatedDate { set; get; }

        string UpdatedBy { set; get; }

        string MeMetaKeyword { set; get; }

        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PassOfficePP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visitor
    {
        public System.Guid ID_Visitor { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public Nullable<int> WorkPlace_ID { get; set; }
        public Nullable<int> WorkSchedule_ID { get; set; }
        public Nullable<int> Category_ID { get; set; }
        public Nullable<int> Post_ID { get; set; }
        public Nullable<int> AccessLevel_ID { get; set; }
        public byte[] VisitorImage { get; set; }
        public System.DateTime CreationDate { get; set; }
    
        public virtual AccessLevel AccessLevel { get; set; }
        public virtual Category Category { get; set; }
        public virtual Post Post { get; set; }
        public virtual WorkPlace WorkPlace { get; set; }
        public virtual WorkSchedule WorkSchedule { get; set; }
    }
}

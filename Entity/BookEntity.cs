using System;
using SqlSugar;

namespace Entity {
    /// <summary>
    /// 图书 实体类
    /// </summary>
    [SugarTable("T_Book")]
    public class BookEntity {
        /// <summary>
        /// 图书编号
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// 图书名称
        /// </summary>
        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }

        public int AdminId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AplicationCore.Interfaces
{
    /// <summary>
    /// BaseRepository InterFace
    /// </summary>
    /// <typeparam name="T">Kiểu dữ liệu truyền vào</typeparam>
    /// CreatedBy: TLKHANH (6/2/2021)
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// Lấy ra dữ liệu linh động theo tham số
        /// </summary>
        /// <param name="sqlcommand">Câu lệnh sql truy vấn</param>
        /// <param name="parameters">Các tham số của câu lệnh sql</param>
        /// <param name="commandType">Kiểu truy vấn đến cơ sở dữ liệu</param>
        /// <returns>Các bản ghi phù hợp với câu lệnh truy vấn</returns>
        IEnumerable<T> Get(string sqlcommand = null, object parameters = null, CommandType commandType = CommandType.Text);
        /// <summary>
        /// Lấy bản ghi theo id
        /// </summary>
        /// <param name="id">id của bản ghi cần lấy</param>
        /// <returns>Bản ghi theo id truyền vào</returns>
        T GetById(string id);
        /// <summary>
        /// Thêm mới một bản ghi
        /// </summary>
        /// <param name="entity">Bản ghi cần thêm mới</param>
        /// <returns>Số dòng bị ảnh hưởng trong cơ sở dữ liệu</returns>
        int Insert(T entity);
        /// <summary>
        /// Cập nhật một bản ghi 
        /// </summary>
        /// <param name="id">Id của bản ghi cần cập nhật</param>
        /// <param name="entity">Bản ghi thay thế</param>
        /// <returns>Số dòng bị ảnh hưởng trong cơ sở dữ liệu</returns>
        int Update(string id, T entity);
        /// <summary>
        /// Xóa một bản ghi
        /// </summary>
        /// <param name="id">Id của bản ghi cần xóa</param>
        /// <returns>Số dòng bị ảnh hưởng trong cơ sở dữ liệu</returns>
        int Delete(string id);
    }
}

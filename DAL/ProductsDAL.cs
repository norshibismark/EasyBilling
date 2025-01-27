﻿using EasyBilling.BLL;
using EasyBilling.BLL.Application;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyBilling.DAL
{
    class ProductsDAL
    {
        #region select data from products table
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetProductDetails", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        #endregion
        #region insert and update data
        public bool insertAndUpdate(ProductsBLL p)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_InsertProductDetails", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = p.id;
                cmd.Parameters.Add("name", SqlDbType.VarChar).Value = p.name;
                cmd.Parameters.Add("category", SqlDbType.VarChar).Value = p.category;
                cmd.Parameters.Add("rate", SqlDbType.Decimal).Value = p.rate;
                cmd.Parameters.Add("qty", SqlDbType.Decimal).Value = p.qty;
                cmd.Parameters.Add("description", SqlDbType.VarChar).Value = p.description;
                cmd.Parameters.Add("added_date", SqlDbType.DateTime).Value = p.added_date;
                cmd.Parameters.Add("added_by", SqlDbType.Int).Value = p.added_by;
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region delete products
        public bool delete(ProductsBLL p)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_DeleteProducts", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = p.id;
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region search products based on keyword
        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_SearchProducts", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("keyword", SqlDbType.VarChar).Value = keyword;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        #endregion
        #region get max product Id
        public int getMaxProductId()
        {
            int maxProductId = 0;
            SqlCommand cmd;
            SqlDataReader reader;
            try
            {
                cmd = new SqlCommand("USP_GetProductsMaxId", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        maxProductId = Common.ConvertToInt(reader["MAXID"]);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return maxProductId;
        }
        #endregion
        #region search products for transation based on keyword
        public ProductsBLL SearchDealerAndCustomerForTransaction(string keyword)
        {
            DataTable dt = new DataTable();
            ProductsBLL p = new ProductsBLL();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_SearchProductsForTransaction", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("keyword", SqlDbType.VarChar).Value = keyword;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                dt = ds.Tables[0];
                if (dt.Rows.Count > 0)
                {
                    p.name = Common.ConvertToString(dt.Rows[0]["name"]);
                    p.rate = Common.ConvertToDouble(dt.Rows[0]["rate"]);
                    p.qty = Common.ConvertToDouble(dt.Rows[0]["qty"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return p;
        }
        #endregion
        #region get product Id from name
        public ProductsBLL getProductIdFromName(string name)
        {
            ProductsBLL p = new ProductsBLL();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetProductIdFromName", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("productName", SqlDbType.VarChar).Value = name;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                adapter.Dispose();
                if (dt.Rows.Count > 0)
                {
                    p.id = Common.ConvertToInt(dt.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return p;
        }
        #endregion
        #region method to get the current quantity from the database based on product id
        public double getProductQuantity(int productId)
        {
            double quantity = 0;
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetCurrentQuantityOfProducts", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = productId;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                adapter.Dispose();

                if(dt.Rows.Count > 0)
                {
                    quantity = Common.ConvertToDouble(dt.Rows[0]["qty"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return quantity;
        }
        #endregion
        #region method to update quantity based on product id
        public bool updateQuantity(int productId,double quantity)
        {
            bool isSuccess = false;
            try
            {
                SqlCommand cmd = new SqlCommand("USP_UpdateQuantityOfProducts", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", SqlDbType.Int).Value = productId;
                cmd.Parameters.Add("quantity", SqlDbType.Decimal).Value = quantity;
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region method to increase the product quantity
        public bool increaseProductQuantity(int productId,double increaseQuantity)
        {
            bool isSuccess = false;
            try
            {
                double currentQuantity = getProductQuantity(productId);
                double newQuantity = currentQuantity + increaseQuantity;
                isSuccess = updateQuantity(productId, newQuantity);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region method to decrease the product quantity
        public bool decreaseProductQuantity(int productId, double decreaseQuantity)
        {
            bool isSuccess = false;
            try
            {
                double currentQuantity = getProductQuantity(productId);
                double newQuantity = currentQuantity - decreaseQuantity;
                isSuccess = updateQuantity(productId, newQuantity);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isSuccess;
        }
        #endregion
        #region display products based on category
        public DataTable DisplayProductsBasedOnCategory(string category)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("USP_GetProductDetailsBasedOncategory", AppManager.ConnectionManager);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("category", SqlDbType.VarChar).Value = category;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        #endregion
    }
}

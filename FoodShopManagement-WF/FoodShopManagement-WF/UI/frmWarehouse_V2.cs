﻿using DTO;
using FoodShopManagement_WF.Presenter;
using FoodShopManagement_WF.Presenter.impl;
using System;
using System.Windows.Forms;

namespace FoodShopManagement_WF.UI
{
    public partial class frmWarehouse_V2 : Form
    {

        private frmLogin loginFrame;
        private TblEmployeesDTO emp;
        private IWarehousePresenter warehousePresenter;
        public frmWarehouse_V2()
        {
            InitializeComponent();
        }
        public TextBox getIdCategory()
        {
            return txtCategoryID;
        }
        public TextBox getNameCategory()
        {
            return txtCategoryName;
        }
        public TextBox getIdProduct()
        {
            return txtProductID;
        }
        public TextBox getNameProduct()
        {
            return txtProductName;
        }
        public TextBox getQuantityProduct()
        {
            return txtQuantity;
        }
        public TextBox getPriceProduct()
        {
            return txtPrice;
        }
        public frmWarehouse_V2(frmLogin loginFrame, TblEmployeesDTO emp)
        {
            InitializeComponent();
            this.loginFrame = loginFrame;
            this.emp = emp;
            warehousePresenter = new WarehousePresenter(this);
        }
        public BindingNavigator GetBindingNavigatorCategory()
        {
            return this.bindingNavigatorCategory;
        }
        public DataGridView GetDataGridViewCategory()
        {
            return this.dtgCategories;
        }
        public DataGridView GetDataGridViewProduct()
        {
            return this.dgvProduct;
        }
        public BindingNavigator GetBindingNavigatorProduct()
        {
            return this.bindingNavigatorProduct;
        }
        public void loadData()
        {
            msTool.Text = "User: " + emp.name;
            warehousePresenter.getAllCategory();
            warehousePresenter.getAllProduct();
            
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            warehousePresenter.addCategory();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginFrame.Show();
        }

        private void frmWarehouse_V2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {

            warehousePresenter.editCategory();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            frmProductDetail ProductDetail = new frmProductDetail(true);
            DialogResult r = ProductDetail.ShowDialog();

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

            frmProductDetail ProductDetail = new frmProductDetail(true);
            DialogResult r = ProductDetail.ShowDialog();

        }

        private void ViewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMyProfileDetailcs ProductDetail = new frmMyProfileDetailcs(this.emp);
            DialogResult r = ProductDetail.ShowDialog();
        }

        private void frmWarehouse_V2_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public ToolStripTextBox getSearchCategoryBox()
        {
            return this.txtSearchCategory;
        }
        private void txtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            warehousePresenter.searchCategory();
        }
       
    }
}

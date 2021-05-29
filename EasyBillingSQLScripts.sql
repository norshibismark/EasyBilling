CREATE DATABASE EasyBilling

GO
---USER
USE [EasyBilling];

-------------------Categories Table------------
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_categories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[description] [varchar](250) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_categories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
----------------------------------------------
------------Dealer and customer table-----------------

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_dealer_customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NULL,
	[name] [varchar](150) NULL,
	[email] [varchar](150) NULL,
	[contact] [varchar](15) NULL,
	[address] [varchar](250) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_dea_cust] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

------------------------------------------------------
--------------------------product details--------------

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[category] [varchar](50) NULL,
	[description] [varchar](250) NULL,
	[rate] [numeric](18, 2) NULL,
	[qty] [numeric](18, 2) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

------------------------------------------------
---------transaction details table-------

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_transaction_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[rate] [numeric](18, 2) NULL,
	[qty] [numeric](18, 2) NULL,
	[total] [numeric](18, 2) NULL,
	[dealer_customer_id] [int] NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
	[tranId] [int] NULL,
 CONSTRAINT [PK_tbl_transaction_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
----------------------------------
--------Transaction table-----------

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [varchar](50) NULL,
	[dealer_customer_id] [int] NULL,
	[grandTotal] [numeric](18, 2) NULL,
	[transaction_date] [datetime] NULL,
	[tax] [numeric](18, 2) NULL,
	[discount] [numeric](18, 2) NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_transactions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

-----------------------------------------------
--Users Table------------

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[email] [varchar](150) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[contact] [varchar](15) NULL,
	[address] [varchar](250) NULL,
	[gender] [varchar](10) NULL,
	[user_type] [varchar](15) NULL,
	[added_date] [datetime] NULL,
	[added_by] [int] NULL,
 CONSTRAINT [PK_tbl_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

----------------------------------------------------------





---------------------Getting user details--------------------
CREATE PROCEDURE USP_GetUsersDetails
AS
BEGIN
	SELECT * FROM tbl_users
END

GO
---------------------Inserting and updating-------------------
CREATE PROCEDURE USP_InsertUsersDetails
(
	@id int,
	@first_name varchar(50),
	@last_name varchar(50),
	@email varchar(150),
	@username varchar(50),
	@password varchar(50),
	@contact varchar(50),
	@address varchar(250),
	@gender varchar(10),
	@user_type varchar(50),
	@added_date datetime,
	@added_by int
)
AS
BEGIN
	DECLARE @COUNT AS Int;
	SET @COUNT = (SELECT COUNT(*) from tbl_users WHERE id=@id);
	IF(@COUNT > 0)
		BEGIN
			UPDATE tbl_users SET first_name=@first_name,last_name=@last_name,email=@email,username=@username,password=@password,contact=@contact,address=@address,gender=@gender,user_type=@user_type,added_date=@added_date,added_by=@added_by WHERE id=@id;
		END
	ELSE
		BEGIN
			INSERT INTO tbl_users(first_name,last_name,email,username,password,contact,address,gender,user_type,added_date,added_by) VALUES(@first_name,@last_name,@email,@username,@password,@contact,@address,@gender,@user_type,@added_date,@added_by);
		END
END

GO
-----------------Deleting users----------------
CREATE PROCEDURE USP_DeleteUsers
(
	@id int
)
AS
BEGIN
	DELETE FROM tbl_users WHERE id=@id;
END

GO
----------------Get Max User Id---------------------
CREATE PROCEDURE USP_GetUsersMaxId
AS
BEGIN
	SELECT ISNULL(MAX(id),0) AS MAXID FROM tbl_users
END

GO
--EXEC USP_GetUsersMaxId

------------Search users based on keyword-------------
CREATE PROCEDURE USP_SearchUsers
(
	@keyword varchar(100)
)
AS
BEGIN
	SELECT * FROM tbl_users WHERE CAST(id as varchar) LIKE '%' + ISNULL(@keyword,0) + '%' OR first_name LIKE '%'+ @keyword +'%' OR last_name LIKE '%'+ @keyword +'%' OR username LIKE '%'+ @keyword +'%' OR contact LIKE '%'+ @keyword +'%';
END

GO
--EXEC USP_SearchUsers '1'
------------get user Id from user name------------------
CREATE PROCEDURE USP_GetUserIdFromUserName
(
	@userName varchar(50)
)
AS
BEGIN
	SELECT id FROM tbl_users WHERE first_name=@userName;
END

GO
--SELECT * FROM tbl_users
-------------------------------------------------------------------

-- LOGIN

-------------- check user entered correct login details------------
CREATE PROCEDURE USP_LoginCheck
(
	@username varchar(50),
	@password varchar(50),
	@user_type varchar(50)
)
AS
BEGIN
	SELECT * FROM tbl_users WHERE username=@username AND password=@password AND user_type=@user_type
END

GO
--EXEC USP_LoginCheck 'Rajesh','rajesh@123','Admin'
-------------------------------------------------------------------

----CATEGORY

---------------------Getting categories details--------------------
CREATE PROCEDURE USP_GetCategoriesDetails
AS
BEGIN
	SELECT * FROM tbl_categories
END

GO
---------------------Inserting and updating-------------------
CREATE PROCEDURE USP_InsertCategoriesDetails
(
	@id int,
	@title varchar(50),
	@description varchar(250),
	@added_date datetime,
	@added_by int
)
AS
BEGIN
	DECLARE @COUNT AS Int;
	SET @COUNT = (SELECT COUNT(*) from tbl_categories WHERE id=@id);
	IF(@COUNT > 0)
		BEGIN
			UPDATE tbl_categories SET title=@title,description=@description,added_date=@added_date,added_by=@added_by WHERE id=@id;
		END
	ELSE
		BEGIN
			INSERT INTO tbl_categories(title,description,added_date,added_by) VALUES(@title,@description,@added_date,@added_by);
		END
END

GO
-----------------Deleting Categories--------------------
CREATE PROCEDURE USP_DeleteCategories
(
	@id int
)
AS
BEGIN
	DELETE FROM tbl_categories WHERE id=@id;
END

GO
----------------Get Max Category Id---------------------
CREATE PROCEDURE USP_GetCategoriesMaxId
AS
BEGIN
	SELECT ISNULL(MAX(id),0) AS MAXID FROM tbl_categories
END

GO
--EXEC USP_GetUsersMaxId

------------Search categories based on keyword---------------
CREATE PROCEDURE USP_SearchCategories
(
	@keyword varchar(100)
)
AS
BEGIN
	SELECT * FROM tbl_categories WHERE CAST(id as varchar) LIKE '%' + ISNULL(@keyword,0) + '%' OR title LIKE '%'+ @keyword +'%' OR description LIKE '%'+ @keyword +'%';
END

GO
---------------------------------------------------------

----- PRODUCT

---------------------Getting product details--------------------
CREATE PROCEDURE USP_GetProductDetails
AS
BEGIN
	SELECT * FROM tbl_products
END

GO
---------------------Inserting and updating-------------------
CREATE PROCEDURE USP_InsertProductDetails
(
	@id int,
	@name varchar(50),
	@category varchar(50),
	@description varchar(250),
	@rate numeric(18,2),
	@qty numeric(18,2),
	@added_date datetime,
	@added_by int
)
AS
BEGIN
	DECLARE @COUNT AS Int;
	SET @COUNT = (SELECT COUNT(*) from tbl_products WHERE id=@id);
	IF(@COUNT > 0)
		BEGIN
			UPDATE tbl_products SET name=@name,category=@category,description=@description,rate=@rate,qty=@qty,added_date=@added_date,added_by=@added_by WHERE id=@id;
		END
	ELSE
		BEGIN
			INSERT INTO tbl_products(name,category,description,rate,qty,added_date,added_by) VALUES(@name,@category,@description,@rate,@qty,@added_date,@added_by);
		END
END

GO
-----------------Deleting Products--------------------
CREATE PROCEDURE USP_DeleteProducts
(
	@id int
)
AS
BEGIN
	DELETE FROM tbl_products WHERE id=@id;
END

GO
----------------Get Max Product Id---------------------
CREATE PROCEDURE USP_GetProductsMaxId
AS
BEGIN
	SELECT ISNULL(MAX(id),0) AS MAXID FROM tbl_products
END

--EXEC USP_GetProductsMaxId
GO
------------Search Products based on keyword---------------
CREATE PROCEDURE USP_SearchProducts
(
	@keyword varchar(100)
)
AS
BEGIN
	SELECT * FROM tbl_products WHERE CAST(id as varchar) LIKE '%' + ISNULL(@keyword,0) + '%' OR name LIKE '%'+ @keyword +'%' OR category LIKE '%'+ @keyword +'%' OR description LIKE '%'+ @keyword +'%';
END

GO
------------Search Products for transaction based on keyword---------------
CREATE PROCEDURE USP_SearchProductsForTransaction
(
	@keyword varchar(100)
)
AS
BEGIN
	SELECT name,rate,qty FROM tbl_products WHERE CAST(id as varchar) LIKE '%' + ISNULL(@keyword,0) + '%' OR name LIKE '%'+ @keyword +'%';
END

GO
------------get product Id from product name------------------
CREATE PROCEDURE USP_GetProductIdFromName
(
	@productName varchar(50)
)
AS
BEGIN
	SELECT id FROM tbl_products WHERE name=@productName;
END

GO
-----get the current quantity based on product id--------------
CREATE PROCEDURE USP_GetCurrentQuantityOfProducts
(
	@id int
)
AS
BEGIN
	SELECT qty FROM tbl_products WHERE id=@id;
END

GO
-----Update quantity based on product id--------------
CREATE PROCEDURE USP_UpdateQuantityOfProducts
(
	@id int,
	@quantity numeric(18,2)
)
AS
BEGIN
	UPDATE tbl_products SET qty=@quantity WHERE id=@id;
END

GO
---------------------display product details based on category--------------------
CREATE PROCEDURE USP_GetProductDetailsBasedOncategory
(
	@category varchar(50)
)
AS
BEGIN
	SELECT * FROM tbl_products WHERE category=@category;
END

GO
----------------------------------------------------------------

-----DEALER AND CUSTOMER

-------------Getting dealer and customer details----------------
CREATE PROCEDURE USP_GetDealerAndCustomerDetails
AS
BEGIN
	SELECT * FROM tbl_dealer_customer
END

GO
---------------------Inserting and updating---------------------
CREATE PROCEDURE USP_InsertDealerAndCustomerDetails
(
	@id int,
	@type varchar(50),
	@name varchar(50),
	@email varchar(150),
	@contact varchar(15),
	@address varchar(150),
	@added_date datetime,
	@added_by int
)
AS
BEGIN
	DECLARE @COUNT AS Int;
	SET @COUNT = (SELECT COUNT(*) from tbl_dealer_customer WHERE id=@id);
	IF(@COUNT > 0)
		BEGIN
			UPDATE tbl_dealer_customer SET type=@type,name=@name,email=@email,contact=@contact,address=@address,added_date=@added_date,added_by=@added_by WHERE id=@id;
		END
	ELSE
		BEGIN
			INSERT INTO tbl_dealer_customer(type,name,email,contact,address,added_date,added_by) VALUES(@type,@name,@email,@contact,@address,@added_date,@added_by);
		END
END

GO
-----------------Deleting Dealers And Customers--------------------
CREATE PROCEDURE USP_DeleteDealersAndCustomers
(
	@id int
)
AS
BEGIN
	DELETE FROM tbl_dealer_customer WHERE id=@id;
END

GO
----------------Get Max Delaer and Customer Id--------------------
CREATE PROCEDURE USP_GetDealersAndCustomerMaxId
AS
BEGIN
	SELECT ISNULL(MAX(id),0) AS MAXID FROM tbl_dealer_customer
END

GO
------------Search dealers and customers based on keyword---------
CREATE PROCEDURE USP_SearchDealersAndCustomers
(
	@keyword varchar(100)
)
AS
BEGIN
	SELECT * FROM tbl_dealer_customer WHERE CAST(id as varchar) LIKE '%' + ISNULL(@keyword,0) + '%' OR name LIKE '%'+ @keyword +'%' OR type LIKE '%'+ @keyword +'%' OR email LIKE '%'+ @keyword +'%' OR contact LIKE '%' + @keyword + '%' OR address LIKE '%'+ @keyword +'%';
END

GO
---Search dealers and customers for transaction based on keyword---
CREATE PROCEDURE USP_SearchDealersAndCustomersForTransaction
(
	@keyword varchar(100)
)
AS
BEGIN
	SELECT name,email,contact,address FROM tbl_dealer_customer WHERE CAST(id as varchar) LIKE '%' + ISNULL(@keyword,0) + '%' OR name LIKE '%'+ @keyword +'%' OR contact LIKE '%' + @keyword + '%';
END

GO
------------get dealer Id from dealer or customer name------------------
CREATE PROCEDURE USP_GetDealerOrCustomerIdFromName
(
	@dealerOrCustomerName varchar(50)
)
AS
BEGIN
	SELECT id FROM tbl_dealer_customer WHERE name=@dealerOrCustomerName;
END

GO
------------------------------------------------------------------
---- Purchase And Sale
--after insert
--set @TRANID = SCOPE_IDENTITY();

--end
--select @TRANID

---------------------Insert transaction-------------------
CREATE PROCEDURE USP_InsertTransactions
(
	@type varchar(50),
	@dealer_customer_id int,
	@grandTotal numeric(18,2),
	@transaction_date datetime,
	@tax numeric(18,2),
	@discount numeric(18,2),
	@added_by int
)
AS
BEGIN
	--DECLARE @COUNT AS Int;
	--SET @COUNT = (SELECT COUNT(*) from tbl_transactions WHERE id=@id);
	--IF(@COUNT > 0)
	--	BEGIN
	--		UPDATE tbl_transactions SET type=@type,dealer_customer_id=@dealer_customer_id,grandTotal=@grandTotal,transaction_date=@transaction_date,tax=@tax,discount=@discount,added_by=@added_by WHERE id=@id;
	--	END
	--ELSE
	--	BEGIN
			INSERT INTO tbl_transactions(type,dealer_customer_id,grandTotal,transaction_date,tax,discount,added_by) VALUES(@type,@dealer_customer_id,@grandTotal,@transaction_date,@tax,@discount,@added_by);
			SELECT @@IDENTITY;
	--		set @TRANID = SCOPE_IDENTITY(); 
	--	END
	--select @TRANID;
END

GO
-------------------Insert transaction details----------------
CREATE PROCEDURE USP_InsertTransactionDetail
(
	@product_id int,
	@rate numeric(18,2),
	@qty numeric(18,2),
	@total numeric(18,2),
	@dealer_customer_id int,
	@added_date datetime,
	@added_by int,
	@tranId int
)
AS
BEGIN
	--DECLARE @COUNT AS Int;
	--SET @COUNT = (SELECT COUNT(*) from tbl_transaction_table WHERE id=@id);
	--IF(@COUNT > 0)
	--	BEGIN
	--		UPDATE tbl_transaction_table SET product_id=@product_id,rate=@rate,qty=@qty,total=@total,dealer_customer_id=@dealer_customer_id,added_date=@added_date,added_by=@added_by WHERE id=@id;
	--	END
	--ELSE
	--	BEGIN
			INSERT INTO tbl_transaction_table(product_id,rate,qty,total,dealer_customer_id,added_date,added_by,tranId) VALUES(@product_id,@rate,@qty,@total,@dealer_customer_id,@added_date,@added_by,@tranId);
	--		set @TRANID = SCOPE_IDENTITY(); 
	--	END
	--select @TRANID;
END

GO
-----------------------------------------------------------------------------
-------------Getting all transaction details----------------
CREATE PROCEDURE USP_GetAllTransactionDetails
AS
BEGIN
	SELECT * FROM tbl_transactions
END

GO
-------------Getting all transaction details based on type----------------
CREATE PROCEDURE USP_GetAllTransactionDetailsBasedOnType
(
@type varchar(50)
)
AS
BEGIN
	SELECT * FROM tbl_transactions WHERE type=@type;
END

GO

----------------------------------------------------------

----Newly added procedures

--------Search dealers and customers based on type--------
CREATE PROCEDURE USP_SearchDealersAndCustomersBasedOnType
(
	@type varchar(50)
)
AS
BEGIN
	SELECT * FROM tbl_dealer_customer WHERE type=@type;
END

GO

-----------------------------------------------------------

-------------Getting all transaction details based on type----------------
CREATE PROCEDURE USP_GetAllTransactionDetailsBasedOnTypeAndTransactionDate
(
@type varchar(50),
@transaction_date datetime
)
AS
BEGIN
	SELECT * FROM tbl_transactions WHERE type=@type and CAST(transaction_date as date)=CAST(@transaction_date as date);
END

GO

----------------------------------------------------------
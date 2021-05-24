CREATE DATABASE EasyBilling

---USER

---------------------Getting user details--------------------
CREATE PROCEDURE USP_GetUsersDetails
AS
BEGIN
	SELECT * FROM tbl_users
END

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

-----------------Deleting users----------------

CREATE PROCEDURE USP_DeleteUsers
(
	@id int
)
AS
BEGIN
	DELETE FROM tbl_users WHERE id=@id;
END

----------------Get Max User Id---------------------

CREATE PROCEDURE USP_GetUsersMaxId
AS
BEGIN
	SELECT ISNULL(MAX(id),0) AS MAXID FROM tbl_users
END

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
EXEC USP_LoginCheck 'Rajesh','rajesh@123','Admin'
-------------------------------------------------------------------

----CATEGORY

---------------------Getting categories details--------------------
CREATE PROCEDURE USP_GetCategoriesDetails
AS
BEGIN
	SELECT * FROM tbl_categories
END

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

-----------------Deleting Categories--------------------

CREATE PROCEDURE USP_DeleteCategories
(
	@id int
)
AS
BEGIN
	DELETE FROM tbl_categories WHERE id=@id;
END

----------------Get Max Category Id---------------------

CREATE PROCEDURE USP_GetCategoriesMaxId
AS
BEGIN
	SELECT ISNULL(MAX(id),0) AS MAXID FROM tbl_categories
END

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

---------------------------------------------------------

----- PRODUCT

---------------------Getting product details--------------------
CREATE PROCEDURE USP_GetProductDetails
AS
BEGIN
	SELECT * FROM tbl_products
END

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

-----------------Deleting Products--------------------

CREATE PROCEDURE USP_DeleteProducts
(
	@id int
)
AS
BEGIN
	DELETE FROM tbl_products WHERE id=@id;
END

----------------Get Max Product Id---------------------

CREATE PROCEDURE USP_GetProductsMaxId
AS
BEGIN
	SELECT ISNULL(MAX(id),0) AS MAXID FROM tbl_products
END

--EXEC USP_GetProductsMaxId

------------Search Products based on keyword---------------

CREATE PROCEDURE USP_SearchProducts
(
	@keyword varchar(100)
)
AS
BEGIN
	SELECT * FROM tbl_products WHERE CAST(id as varchar) LIKE '%' + ISNULL(@keyword,0) + '%' OR name LIKE '%'+ @keyword +'%' OR category LIKE '%'+ @keyword +'%' OR description LIKE '%'+ @keyword +'%';
END

----------------------------------------------------------------

-----DEALER AND CUSTOMER

-------------Getting dealer and customer details----------------
CREATE PROCEDURE USP_GetDealerAndCustomerDetails
AS
BEGIN
	SELECT * FROM tbl_dealer_customer
END

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

-----------------Deleting Dealers And Customers--------------------

CREATE PROCEDURE USP_DeleteDealersAndCustomers
(
	@id int
)
AS
BEGIN
	DELETE FROM tbl_dealer_customer WHERE id=@id;
END

----------------Get Max Delaer and Customer Id--------------------

CREATE PROCEDURE USP_GetDealersAndCustomerMaxId
AS
BEGIN
	SELECT ISNULL(MAX(id),0) AS MAXID FROM tbl_dealer_customer
END

------------Search dealers and customers based on keyword---------

CREATE PROCEDURE USP_SearchDealersAndCustomers
(
	@keyword varchar(100)
)
AS
BEGIN
	SELECT * FROM tbl_dealer_customer WHERE CAST(id as varchar) LIKE '%' + ISNULL(@keyword,0) + '%' OR name LIKE '%'+ @keyword +'%' OR type LIKE '%'+ @keyword +'%' OR email LIKE '%'+ @keyword +'%' OR contact LIKE '%' + @keyword + '%' OR address LIKE '%'+ @keyword +'%';
END

------------------------------------------------------------------
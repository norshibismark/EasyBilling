CREATE DATABASE EasyBilling

---USER

---------------------Getting user details--------------------
CREATE PROCEDURE USP_GetUsers
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

---------------------Getting user details--------------------
CREATE PROCEDURE USP_GetCategories
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

------------Search users based on keyword---------------

CREATE PROCEDURE USP_SearchCategories
(
	@keyword varchar(100)
)
AS
BEGIN
	SELECT * FROM tbl_categories WHERE CAST(id as varchar) LIKE '%' + ISNULL(@keyword,0) + '%' OR title LIKE '%'+ @keyword +'%' OR description LIKE '%'+ @keyword +'%';
END

---------------------------------------------------------
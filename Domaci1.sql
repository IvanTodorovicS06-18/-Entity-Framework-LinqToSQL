USE TSQL;
GO

--READ

CREATE PROC Production.PRead
AS
SET LOCK_TIMEOUT 3000; --max 3 sec za wait
BEGIN TRY
	SELECT *
	FROM Production.Suppliers
	ORDER BY supplierid
END TRY
BEGIN CATCH
	RETURN ERROR_NUMBER();
END CATCH
GO


--INSERT

CREATE PROC Production.PInsert
@companyname nvarchar(40), @contactname nvarchar(30), @contacttitle nvarchar(30),
@address nvarchar(60), @city nvarchar(15), @region nvarchar(15), @postalcode nvarchar(10), @country nvarchar(15), 
@phone nvarchar(24), @fax nvarchar(24) 
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
	INSERT INTO Production.Suppliers(companyname, contactname, contacttitle, address, city, region, postalcode, country, phone, fax)
	VALUES(@companyname, @contactname, @contacttitle, @address, @city, @region, @postalcode, @country, @phone, @fax)
END TRY
BEGIN CATCH
RETURN ERROR_NUMBER();
END CATCH
GO





--DELTE

CREATE PROC Production.PDelete
@supplierid int
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
	DELETE FROM Production.Suppliers 
	WHERE supplierid = @supplierid
END TRY
BEGIN CATCH
RETURN ERROR_NUMBER();
END CATCH
GO




--UPDATE
GO
CREATE PROC Production.PUpdate
@supplierid int,@companyname nvarchar(40), @contactname nvarchar(30), @contacttitle nvarchar(30),
@address nvarchar(60), @city nvarchar(15), @region nvarchar(15), @postalcode nvarchar(10), @country nvarchar(15), 
@phone nvarchar(24), @fax nvarchar(24) 
AS
SET LOCK_TIMEOUT 3000;
BEGIN TRY
	UPDATE Production.Suppliers
	SET contactname = @contactname,companyname = @companyname, contacttitle = @contacttitle,  address = @address, city = @city, region = @region, postalcode = @postalcode, country = @country, phone = @phone, fax = @fax
	WHERE supplierid = @supplierid
END TRY
BEGIN CATCH
RETURN ERROR_NUMBER();
END CATCH
GO


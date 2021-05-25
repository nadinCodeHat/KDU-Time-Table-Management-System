CREATE PROCEDURE login_proc(@email varchar(50),@password varbinary(MAX))
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @status int
	IF EXISTS(SELECT * FROM Login_Info where email=@email and password=@password)
       set @status=1
	ELSE
       set @status=0
SELECT @status
END
create trigger TRG_TelNoDuzelt9 on Telefon1
after insert
as
begin
	if exists(select * from inserted)
	begin
	declare @tel nvarchar(50),@id int
	select @tel=TelNo,@id=ID from inserted
	if(LEFT(@tel,1)=0)
	begin
	set @tel=SUBSTRING(@tel,2,11)
	end
	
	if(LEN(@tel)>11)
	begin
	RAISERROR(N'TelNo 10 haneden fazla olamaz...', 16, 1);
	end
	
	select @tel='('+LEFT(@tel,3)+')'+SUBSTRING(@tel,4,3)+'-'+SUBSTRING(@tel,7,2)+'-'+SUBSTRING(@tel,9,2) from Telefon1 where ID=@id
	update Telefon1 set TelNo=@tel where ID=@id
	end
end


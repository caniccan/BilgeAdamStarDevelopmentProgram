create trigger TRG_SilmeIslem on Soruu
after delete,update
as
begin
	if exists(select * from deleted)
	begin
	declare @id int, @soruDetay nvarchar(MAX),@soruCozum nvarchar(MAX),@konuID int,@sinifID int,@zorlukID int,@cesitID int
		select @id=ID,@soruDetay=SoruDetay,@soruCozum=SoruCozum,@konuID=KonuID,@sinifID=SinifID,@zorlukID=ZorlukID,@cesitID=CesitID from deleted
		insert into dbo.Yedek(ID,SoruDetay,SoruCozum,KonuID,SinifID,ZorlukID,CesitID)
		values(@id,@soruDetay,@soruCozum,@konuID,@sinifID,@zorlukID,@cesitID)

		
		
	end
end
drop trigger TRG_SilmeIslem

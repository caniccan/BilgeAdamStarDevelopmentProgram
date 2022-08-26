--parametre olarak kullanýcýdan 236/01/1989 25  yaþý hesaplayacak ay gun ve yýl deðerleri doðru girilmiþ mi bir de bu bilgi yani yaþý doðru mu 
	create function FN_YasHesapla(@dogumTarihi nvarchar(50),@yasBilgisi int)
	returns bit
	as
	begin
			declare @gün nvarchar(50),@ay nvarchar(50),@yil nvarchar(50)
			select @gün=value from string_split(@dogumTarihi,'/',1)
			select @ay=value from string_split(@dogumTarihi,'/',2)
			select @yil=value from string_split(@dogumTarihi,'/',3)

			if(COUNT(@gün)=2 AND COUNT(@ay)=2 AND @ay<13 AND COUNT(@yil)=4 AND @yil<2023)
			begin
				if(2022-@yil=@yasBilgisi)
				begin
					return 1
					print 'Girilen Yaþ Bilgisi Doðru...'
					
				end
				else
				begin
					
					print 'Girilen Yaþ Bilgisi Yanlýþ...'
				end
			end
			else
			begin
				
				print 'Girilen Doðum Tarihi Formata Uymuyor...'
			end
			
	end


	--select FN_YasHesapla('27/05/1989',27)
--parametre olarak kullan�c�dan 236/01/1989 25  ya�� hesaplayacak ay gun ve y�l de�erleri do�ru girilmi� mi bir de bu bilgi yani ya�� do�ru mu 
	create function FN_YasHesapla(@dogumTarihi nvarchar(50),@yasBilgisi int)
	returns bit
	as
	begin
			declare @g�n nvarchar(50),@ay nvarchar(50),@yil nvarchar(50)
			select @g�n=value from string_split(@dogumTarihi,'/',1)
			select @ay=value from string_split(@dogumTarihi,'/',2)
			select @yil=value from string_split(@dogumTarihi,'/',3)

			if(COUNT(@g�n)=2 AND COUNT(@ay)=2 AND @ay<13 AND COUNT(@yil)=4 AND @yil<2023)
			begin
				if(2022-@yil=@yasBilgisi)
				begin
					return 1
					print 'Girilen Ya� Bilgisi Do�ru...'
					
				end
				else
				begin
					
					print 'Girilen Ya� Bilgisi Yanl��...'
				end
			end
			else
			begin
				
				print 'Girilen Do�um Tarihi Formata Uymuyor...'
			end
			
	end


	--select FN_YasHesapla('27/05/1989',27)
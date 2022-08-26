


create proc sp_Konum(@countryName nvarchar(50),@cityName nvarchar(50),@districtName nvarchar(50),@townName nvarchar(50))
	as
	begin
		if exists(select * from Country where CountryName=@countryName)
		begin
			print 'Gönderilen Ülke Tabloda Var...'
		end
		else
		begin 
			Insert into Country(CountryName)
			values(@countryName)
		end

		if exists(select City.CityName,Country.CountryName from City,Country where Country.ID=City.CountryID)
			begin
			declare @countryID int
			select @countryID=Country.ID from Country
				insert into City(CityName,CountryID)
				values(@cityName,@countryID)
			end
			else
			begin
				insert into City(CityName)
				values(@cityName)
			end

			if exists(select District.DistrictName,City.CityName,Country.CountryName from District,City,Country where District.CityID=City.ID AND City.CountryID=Country.ID)
				begin
					declare @cityID int
					select @cityID=City.ID,@countryID=Country.ID from Country,City	
					print 'Ülke o ülkeye baðlý þehir ve o þehire baðlý ýlçe var...'
				end
				else if exists(select District.DistrictName,City.CityName,Country.CountryName from District,City,Country where City.CountryID!=Country.ID)
				begin 
					insert into Country(CountryName)
					values(@countryName)
			
					insert into City(CountryID,CityName)
					values(@countryID,@cityName)

					insert into District(CountryID,CityID,DistrictName)
					values(@countryID,@cityID,@districtName)
				end
				else if exists(select District.DistrictName,City.CityName,Country.CountryName from District,City,Country where District.CityID!=City.ID AND City.CountryID=Country.ID)
				begin
					insert into City(CountryID,CityName)
					values(@countryID,@cityName)

					insert into District(CountryID,CityID,DistrictName)
					values(@countryID,@cityID,@districtName)
				end

			if exists(select Town.TownName,District.DistrictName,City.CityName,Country.CountryName from Town,District,City,Country where Town.DistrictID=District.ID AND District.CityID=City.ID AND City.CountryID=Country.ID)
				begin
					print 'Ülke o ülkeye baðlý þehir ve o þehire baðlý ýlçe var...'
				end
				else if exists(select Town.TownName,District.DistrictName,City.CityName,Country.CountryName from Town,District,City,Country where Town.DistrictID=District.ID AND District.CityID=City.ID AND City.CountryID!=Country.ID)
					begin
						declare @districtID int
						select @districtID=District.ID from District
						insert into Country(CountryName)
						values(@countryName)

						insert into City(CountryID,CityName)
						values(@countryID,@cityName)

						insert into District(CountryID,CityID,DistrictName)
						values(@countryID,@cityID,@districtName)

						insert into Town(TownName,CountryID,CityID,DistrictID)
						values(@townName,@countryID,@cityID,@districtID)
					end
				else if exists(select Town.TownName,District.DistrictName,City.CityName,Country.CountryName from Town,District,City,Country where Town.DistrictID=District.ID AND District.CityID!=City.ID AND City.CountryID=Country.ID)
					begin
						insert into City(CountryID,CityName)
						values(@countryID,@cityName)

						insert into District(CountryID,CityID,DistrictName)
						values(@countryID,@cityID,@districtName)

						insert into Town(TownName,CountryID,CityID,DistrictID)
						values(@townName,@countryID,@cityID,@districtID)
					end
				else if exists(select Town.TownName,District.DistrictName,City.CityName,Country.CountryName from Town,District,City,Country where Town.DistrictID!=District.ID AND District.CityID=City.ID AND City.CountryID=Country.ID)
					begin
						insert into District(CountryID,CityID,DistrictName)
						values(@countryID,@cityID,@districtName)

						insert into Town(TownName,CountryID,CityID,DistrictID)
						values(@townName,@countryID,@cityID,@districtID)
					end
				else if exists(select Town.TownName,District.DistrictName,City.CityName,Country.CountryName from Town,District,City,Country where Town.DistrictID=District.ID AND District.CityID=City.ID AND City.CountryID=Country.ID)
					begin
						insert into Town(TownName,CountryID,CityID,DistrictID)
						values(@townName,@countryID,@cityID,@districtID)
					end
	end




	--exec sp_Konum
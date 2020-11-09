create proc DTB (@mahs varchar(10))
as
begin
select HS.TenHS, AVG(DiemHS.Diem) AS DiemTB
from 
(select D.MaMon, M.TenMon, D.Diem
from Diem D, MonHoc M
where D.MaMon = M.MaMon
and D.MaHS = @mahs) as DiemHS, HocSinh HS
where HS.MaHS = @mahs
group by HS.TenHS
end
exec DTB 'HS01'
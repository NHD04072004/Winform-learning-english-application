CREATE DATABASE QUANLYKHOAHOCTIENGANH;

USE QUANLYKHOAHOCTIENGANH;


CREATE TABLE [dbo].[tblTaiKhoan] (
    [iMaTK]       INT IDENTITY(1,1),
    [sTenTK]      VARCHAR (50) NOT NULL ,
    [sEmail]      VARCHAR (MAX) NULL,
    [sMatKhau]    VARCHAR (50)  NOT NULL,
    [bCheckAdmin] BIT           CONSTRAINT [DEFAULT_tblTaiKhoan_bCheckAdmin] DEFAULT 0 NOT NULL,
    CONSTRAINT [PK_tblTaiKhoan] PRIMARY KEY CLUSTERED ([iMaTK] ASC)
);
GO
CREATE TABLE [dbo].[tblKhoaHoc] (
    [sMaKhoaHoc]  VARCHAR (10)   NOT NULL,
    [sTenKhoaHoc] NVARCHAR (MAX) NOT NULL,
	[bIsDeleted]  BIT            CONSTRAINT [DEFAULT_tblKhoaHoc_bIsDeleted] DEFAULT 0 NOT NULL,
    CONSTRAINT [PK_tblKhoaHoc] PRIMARY KEY CLUSTERED ([sMaKhoaHoc] ASC)
);
GO
CREATE TABLE [dbo].[tblBaiHoc] (
    [sMaBaiHoc]  VARCHAR (10)   NOT NULL,
    [sTenBaiHoc] NVARCHAR (MAX) NOT NULL,
    [sMaKhoaHoc] VARCHAR (10)   NOT NULL,
	[bIsDeleted] BIT            CONSTRAINT [DEFAULT_tblBaiHoc_bIsDeleted] DEFAULT 0 NOT NULL,
    CONSTRAINT [PK_tblBaiHoc] PRIMARY KEY CLUSTERED ([sMaBaiHoc] ASC),
    CONSTRAINT [FK_tblBaiHoc_tblKhoaHoc] FOREIGN KEY ([sMaKhoaHoc]) REFERENCES [dbo].[tblKhoaHoc] ([sMaKhoaHoc])
);
GO

CREATE TABLE [dbo].[tblCauHoi] (
    [sMaCauHoi] VARCHAR (10) NOT NULL,
    [sMaBaiHoc] VARCHAR (10) NOT NULL,
    [bIsDeleted]     BIT          CONSTRAINT [DEFAULT_tblCauHoi_bIsDeleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tblCauHoi] PRIMARY KEY CLUSTERED ([sMaCauHoi] ASC),
    CONSTRAINT [FK_tblCauHoi_tblBaiHoc] FOREIGN KEY ([sMaBaiHoc]) REFERENCES [dbo].[tblBaiHoc] ([sMaBaiHoc])
);
GO
ALTER TABLE tblCauHoi ADD sNoiDungCauHoi TEXT NOT NULL

CREATE TABLE [dbo].[tblDapAn] (
    [sMaDapAn]      VARCHAR (10)   NOT NULL,
    [sMaCauHoi]     VARCHAR (10)   NOT NULL,
    [sNoiDungDapAn] NVARCHAR (MAX) NOT NULL,
    [bDapAnDung]    BIT            NOT NULL,
	[bIsDeleted]    BIT            CONSTRAINT [DEFAULT_tblDapAn_bIsDeleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tblDapAn] PRIMARY KEY CLUSTERED ([sMaDapAn] ASC),
    CONSTRAINT [FK_tblDapAn_tblCauHoi] FOREIGN KEY ([sMaCauHoi]) REFERENCES [dbo].[tblCauHoi] ([sMaCauHoi])
);
GO
CREATE TABLE [dbo].[tblDanhSachKhoaHocDangKy] (
    [iMaTK]         INT NOT NULL,
    [sMaKhoaHoc]    VARCHAR (10) NOT NULL,
    [bTrangThaiHoc] BIT          NULL,
	[bIsDeleted]    BIT            CONSTRAINT [DEFAULT_tblDanhSachKhoaHocDangKy_bIsDeleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_tblDanhSachKhoaHocDangKy] PRIMARY KEY CLUSTERED ([iMaTK] ASC, [sMaKhoaHoc] ASC),
    CONSTRAINT [FK_tblDanhSachKhoaHocDangKy_tblKhoaHoc] FOREIGN KEY ([sMaKhoaHoc]) REFERENCES [dbo].[tblKhoaHoc] ([sMaKhoaHoc]),
    CONSTRAINT [FK_tblDanhSachKhoaHocDangKy_tblTaiKhoan] FOREIGN KEY ([iMaTK]) REFERENCES [dbo].[tblTaiKhoan] ([iMaTK])
);
GO
CREATE TABLE [dbo].[tblBangKetQua] (
    [sMaKetQua]    VARCHAR (10) NOT NULL,
    [iMaTK]        INT NOT NULL,
    [sMaBaiHoc]    VARCHAR (10) NOT NULL,
    [dThoiGianNop] DATETIME     NULL,
    [fDiem]        FLOAT CHECK(fDiem BETWEEN 0 AND 10) DEFAULT(0),
    CONSTRAINT [PK_tblBangKetQua] PRIMARY KEY CLUSTERED ([sMaKetQua] ASC),
    CONSTRAINT [FK_tblBangKetQua_tblBaiHoc] FOREIGN KEY ([sMaBaiHoc]) REFERENCES [dbo].[tblBaiHoc] ([sMaBaiHoc]),
    CONSTRAINT [FK_tblBangKetQua_tblTaiKhoan] FOREIGN KEY ([iMaTK]) REFERENCES [dbo].[tblTaiKhoan] ([iMaTK])
);

ALTER TABLE [dbo].[tblBangKetQua] ALTER COLUMN [dThoiGianNop] DATETIME NULL;

GO
CREATE TABLE [dbo].[tblBangTraLoi] (
    [sMaTraLoi]      VARCHAR (10) NOT NULL,
    [sMaKetQua]      VARCHAR (10) NOT NULL,
    [sMaCauHoi]      VARCHAR (10) NOT NULL,
    [sMaDapAnTraLoi] VARCHAR (10) NOT NULL,
	[bDapAnDung]     BIT          NULL,
    CONSTRAINT [PK_tblBangTraLoi] PRIMARY KEY CLUSTERED ([sMaTraLoi] ASC),
    CONSTRAINT [FK_tblBangTraLoi_tblBangKetQua] FOREIGN KEY ([sMaKetQua]) REFERENCES [dbo].[tblBangKetQua] ([sMaKetQua])
);
GO


﻿-- NHẬP DỮ LIỆU CHO CÁC BẢNG

-- BẢNG TÀI KHOẢN
INSERT INTO [dbo].[tblTaiKhoan] ([sTenTK], [sEmail], [sMatKhau], [bCheckAdmin])
VALUES
    ('masteradmin', 'admin123@example.com', 'SecurePass45', 1),
    ('johndoe', 'johndoe99@example.com', 'JDoe456', 0),
    ('alicewonder', 'alicew@example.com', 'AlicePass77', 0),
    ('crazycat', 'crazycat@example.com', 'MeowMeow22', 0),
    ('sunflowergirl', 'sunnydays@example.com', 'FlowerPower99', 0),
    ('techguru42', 'techguru42@example.com', 'Techie007', 0),
    ('randomuserx', 'randomx@example.com', 'XFactor321', 0),
    ('travellover', 'globetrotter@example.com', 'Wanderlust89', 0),
    ('bookwormy', 'bookworm@example.com', 'ReadMore2024', 0),
    ('gaminglegends', 'gamelegend@example.com', 'Passw0rdGame', 0);
GO

-- BẢNG KHÓA HỌC
INSERT INTO [dbo].[tblKhoaHoc] ([sMaKhoaHoc], [sTenKhoaHoc],[bIsDeleted])
VALUES
    ('KH001', N'Tiếng Anh cơ bản',0),
    ('KH002', N'Tiếng Anh nâng cao',0),
    ('KH003', N'Tiếng Anh siêu cấp',0);
GO

-- BẢNG DANH SÁCH KHÓA HỌC ĐĂNG KÝ
INSERT INTO [dbo].[tblDanhSachKhoaHocDangKy] ([iMaTK], [sMaKhoaHoc], [bTrangThaiHoc],[bIsDeleted])
VALUES
    (1, 'KH001', NULL,0),
	(1, 'KH003', NULL,0),
	(1, 'KH002', NULL,0),
    (2, 'KH003', NULL,0),
	(2, 'KH001', NULL,0),
	(2, 'KH002', NULL,0),
    (3, 'KH001', NULL,0),
	(3, 'KH002', NULL,0),
    (4, 'KH002', NULL,0),
	(4, 'KH003', NULL,0),
    (5, 'KH003', NULL,0),
	(5, 'KH001', NULL,0),
    (6, 'KH001', NULL,0),
	(6, 'KH002', NULL,0),
    (7, 'KH002', NULL,0),
	(7, 'KH003', NULL,0),
    (8, 'KH001', NULL,0),
    (9, 'KH002', NULL,0),
	(9, 'KH003', NULL,0),
    (10, 'KH001', NULL,0),
	(10, 'KH003', NULL,0);
GO

--DANH SÁCH BÀI HỌC
INSERT INTO [dbo].[tblBaiHoc] ([sMaBaiHoc],[sTenBaiHoc],[sMaKhoaHoc],[bIsDeleted])
VALUES 
	('BH001',N'Thì hiện tại đơn','KH001',0),
	('BH002',N'Thì quá khứ đơn','KH001',0),
	('BH003',N'Thì tương lai đơn','KH001',0),
	('BH004',N'Câu điều kiện loại I','KH002',0),
	('BH005',N'Câu điều kiện loại II','KH002',0);
GO

-- BẢNG CÂU HỎI
INSERT INTO [dbo].[tblCauHoi] ([sMaCauHoi],[sMaBaiHoc],[sNoiDungCauHoi],[bIsDeleted])
VALUES
	('CH001','BH001','My brother always .......... Saturday dinner.(make)',0),
	('CH002','BH001','....... Mark .......... to school every day? (go)',0),
	('CH003','BH001','Where ........... your sister ..............? (work)',0),
	('CH004','BH001','We always travel by bus. We ............... (own) a car.',0),
	('CH005','BH001','Matthew is good at basketball. He ............... (win) every game.',0),
	('CH006','BH002','My sister (get) married last month.',0),
	('CH007','BH002','My computer (be ) broken yesterday.',0),
	('CH008','BH002','He (buy) me a big teddy bear on my birthday last week.',0),
	('CH009','BH002','My friend (give) me a bar of chocolate when I (be) at school yesterday.',0),
	('CH010','BH002','My children (not do) their homework last night.',0),
	('CH011','BH003','They (do) it for you tomorrow.',0),
	('CH012','BH003','My father (call) you in 5 minutes.',0),
	('CH013','BH003','We believe that she (recover) from her illness soon.',0),
	('CH014','BH003','I promise I (return) school on time.',0),
	('CH015','BH003','If it rains, he (stay) at home',0),
	('CH016','BH004','If I _____ (study), I _____ (pass) the exams.',0),
	('CH017','BH004','If the sun _____ (shine), we _____ (walk) to the town.',0),
	('CH018','BH004','If he _____ (have) a temperature, he _____ (see) the doctor.',0),
	('CH019','BH005','If I had a typewriter, I __________ (type) it myself.',0),
	('CH020','BH005','If I __________ (know) his address, I had give it to you.',0),
	('CH021','BH005','He __________ (look) a lot better if he shaved more often.',0);
GO

-- BẢNG ĐÁP ÁN
INSERT INTO [dbo].[tblDapAn]([sMaDapAn],[sMaCauHoi],[sNoiDungDapAn],[bDapAnDung])
VALUES
	(' DA001','CH001','make',0),
	(' DA002','CH001','makes',1),
	(' DA003','CH001','made',0),
	(' DA004','CH001','maken',0),

	(' DA005','CH002','do, go',0),
	(' DA006','CH002','do, goes',0),
	(' DA007','CH002','does, go',1),
	(' DA008','CH002','does, goes',0),

	(' DA009','CH003','do, work',0),
	(' DA010','CH003','does, work',1),
	(' DA011','CH003','do, workes',0),
	(' DA012','CH003','did,work',0),

	(' DA013','CH004','win',0),
	(' DA014','CH004','won',0),
	(' DA015','CH004','will',0),
	(' DA016','CH004','wins',1),

	(' DA017','CH005','do not own',1),
	(' DA018','CH005','did not own',0),
	(' DA019','CH005','own',0),
	(' DA020','CH005','does',0),

	('DA021','CH006','got',1),
	('DA022','CH006','get',0),
	('DA023','CH006','gets',0),
	('DA024','CH006','getting',0),

	('DA025','CH007','was',1),
	('DA026','CH007','is',0),
	('DA027','CH007','were',0),
	('DA028','CH007','be',0),

	('DA029','CH008','bought',1),
	('DA030','CH008','buy',0),
	('DA031','CH008','buys',0),
	('DA032','CH008','buying',0),

	('DA033','CH009','gave - was',1),
	('DA034','CH009','give - is',0),
	('DA035','CH009','gave - were',0),
	('DA036','CH009','giving - was',0),

	('DA037','CH010','did not do',1),
	('DA038','CH010','do not do',0),
	('DA039','CH010','does not do',0),
	('DA040','CH010','done',0),

	('DA041','CH011','will do',1),
	('DA042','CH011','do',0),
	('DA043','CH011','does',0),
	('DA044','CH011','did',0),

	('DA045','CH012','will call',1),
	('DA046','CH012','call',0),
	('DA047','CH012','calls',0),
	('DA048','CH012','called',0),

	('DA049','CH013','will recover',1),
	('DA050','CH013','recovers',0),
	('DA051','CH013','recover',0),
	('DA052','CH013','recovered',0),

	('DA053','CH014','will return',1),
	('DA054','CH014','return',0),
	('DA055','CH014','returns',0),
	('DA056','CH014','returned',0),

	('DA057','CH015','will stay',1),
	('DA058','CH015','stays',0),
	('DA059','CH015','stay',0),
	('DA060','CH015','stayed',0),

	('DA061','CH016','study - will pass',1),
	('DA062','CH016','studies - passes',0),
	('DA063','CH016','studying - passing',0),
	('DA064','CH016','studied - passed',0),

	('DA065','CH017','shines - will walk',1),
	('DA066','CH017','shone - walked',0),
	('DA067','CH017','shining - walking',0),
	('DA068','CH017','shines - walk',0),

	('DA069','CH018','has - will see',1),
	('DA070','CH018','have - see',0),
	('DA071','CH018','had - saw',0),
	('DA072','CH018','having - seeing',0),

	('DA073','CH019','would type',1),
	('DA074','CH019','typed',0),
	('DA075','CH019','types',0),
	('DA076','CH019','typing',0),

	('DA077','CH020','knew',1),
	('DA078','CH020','know',0),
	('DA079','CH020','knows',0),
	('DA080','CH020','knowing',0),

	('DA081','CH021','would look',1),
	('DA082','CH021','looked',0),
	('DA083','CH021','looks',0),
	('DA084','CH021','looking',0);
GO

-- BẢNG TRẢ LỜI
INSERT INTO [dbo].[tblBangTraLoi] ([sMaTraLoi], [sMaKetQua], [sMaCauHoi], [sMaDapAnTraLoi])
VALUES
    ('TL001', 'KQ001', 'CH001', 'DA002'),
    ('TL002', 'KQ001', 'CH002', 'DA007'),
    ('TL003', 'KQ001', 'CH003', 'DA010'),
    ('TL004', 'KQ001', 'CH004', 'DA016'),
    ('TL005', 'KQ001', 'CH005', 'DA017'),

    ('TL006', 'KQ002', 'CH001', 'DA002'),
    ('TL007', 'KQ002', 'CH002', 'DA007'),
    ('TL008', 'KQ002', 'CH003', 'DA010'),
    ('TL009', 'KQ002', 'CH004', 'DA016'),
    ('TL010', 'KQ002', 'CH005', 'DA017'),

    ('TL011', 'KQ003', 'CH006', 'DA021'),
    ('TL012', 'KQ003', 'CH007', 'DA025'),
    ('TL013', 'KQ003', 'CH008', 'DA029'),
    ('TL014', 'KQ003', 'CH009', 'DA033'),
    ('TL015', 'KQ003', 'CH010', 'DA037'),

    ('TL016', 'KQ004', 'CH006', 'DA022'),
    ('TL017', 'KQ004', 'CH007', 'DA026'),
    ('TL018', 'KQ004', 'CH008', 'DA030'),
    ('TL019', 'KQ004', 'CH009', 'DA034'),
    ('TL020', 'KQ004', 'CH010', 'DA038'),

    ('TL021', 'KQ005', 'CH011', 'DA041'),
    ('TL022', 'KQ005', 'CH012', 'DA045'),
    ('TL023', 'KQ005', 'CH013', 'DA049'),
    ('TL024', 'KQ005', 'CH014', 'DA053'),
    ('TL025', 'KQ005', 'CH015', 'DA057'),

    ('TL026', 'KQ006', 'CH016', 'DA061'),
    ('TL027', 'KQ006', 'CH017', 'DA065'),
    ('TL028', 'KQ006', 'CH018', 'DA069'),
    ('TL029', 'KQ006', 'CH019', 'DA073'),
    ('TL030', 'KQ006', 'CH020', 'DA077');
GO

-- BẢNG KẾT QUẢ
INSERT INTO [dbo].[tblBangKetQua] ([sMaKetQua], [iMaTK], [sMaBaiHoc], [dThoiGianNop], [fDiem])
VALUES
    ('KQ001', 2, 'BH001', '2025-03-10 10:15:00', 8.5),
    ('KQ002', 3, 'BH001', '2025-03-10 11:00:00', 9.0),
    ('KQ003', 4, 'BH002', '2025-03-10 12:30:00', 7.5),
    ('KQ004', 5, 'BH002', '2025-03-10 14:00:00', 6.0),
    ('KQ005', 6, 'BH003', '2025-03-10 15:45:00', 9.2),
    ('KQ006', 7, 'BH003', '2025-03-10 16:20:00', 8.0);
GO

select * from tblBaiHoc;
select * from tblBangKetQua;
select * from tblBangTraLoi;
select * from tblCauHoi;
select * from tblDanhSachKhoaHocDangKy;
select * from tblDapAn;
select * from tblKhoaHoc;
select * from tblTaiKhoan;

create proc pr_AddCourse
	@sMaKhoaHoc varchar(10),
	@sTenKhoaHoc nvarchar(max)
as
begin
	if exists (select 1 from tblKhoaHoc where sMaKhoaHoc = @sMaKhoaHoc)
	begin
		RAISERROR ('Mã khóa học đã tồn tại!', 16, 1);
        RETURN;
	end
	insert into tblKhoaHoc(sMaKhoaHoc, sTenKhoaHoc)
	values(@sMaKhoaHoc, @sTenKhoaHoc)
end;

create proc pr_AddCourseWithExistID
	@sMaKhoaHoc varchar(10),
	@sTenKhoaHoc nvarchar(max)
as
begin
	update tblKhoaHoc
	set bIsDeleted = 0, sTenKhoaHoc = @sTenKhoaHoc
	where sMaKhoaHoc = @sMaKhoaHoc and bIsDeleted = 1
end;

create proc pr_DeleteCourse
	@sMaKhoaHoc varchar(10)
as
begin
	IF NOT EXISTS (SELECT 1 FROM tblKhoaHoc WHERE sMaKhoaHoc = @sMaKhoaHoc AND bIsDeleted = 0)
    BEGIN
        PRINT N'Khóa học không tồn tại hoặc đã bị xóa.';
        RETURN;
    END
	UPDATE tblDapAn 
    SET bIsDeleted = 1
    WHERE sMaCauHoi IN (SELECT sMaCauHoi FROM tblCauHoi WHERE sMaBaiHoc IN 
                        (SELECT sMaBaiHoc FROM tblBaiHoc WHERE sMaKhoaHoc = @sMaKhoaHoc));
    UPDATE tblCauHoi 
    SET bIsDeleted = 1
    WHERE sMaBaiHoc IN (SELECT sMaBaiHoc FROM tblBaiHoc WHERE sMaKhoaHoc = @sMaKhoaHoc);
    UPDATE tblBaiHoc 
    SET bIsDeleted = 1
    WHERE sMaKhoaHoc = @sMaKhoaHoc;
    UPDATE tblDanhSachKhoaHocDangKy
    SET bIsDeleted = 1
    WHERE sMaKhoaHoc = @sMaKhoaHoc;
    UPDATE tblKhoaHoc 
    SET bIsDeleted = 1
    WHERE sMaKhoaHoc = @sMaKhoaHoc;

    PRINT N'Xóa khóa học thành công.';
end

create proc pr_SuaCourse
	@sMaKhoaHoc varchar(10),
	@sTenKhoaHoc nvarchar(max)
as
begin
	update tblKhoaHoc
	set sTenKhoaHoc = @sTenKhoaHoc
	where sMaKhoaHoc = @sMaKhoaHoc;
end;

CREATE PROCEDURE pr_DeleteBaiHoc
    @sMaBaiHoc VARCHAR(10)
AS
BEGIN
    -- Kiểm tra xem bài học có tồn tại không
    IF NOT EXISTS (SELECT 1 FROM tblBaiHoc WHERE sMaBaiHoc = @sMaBaiHoc)
    BEGIN
        RAISERROR ('Bài học không tồn tại!', 16, 1);
        RETURN;
    END

    -- Cập nhật trạng thái xóa mềm (soft delete)
    UPDATE tblDapAn
    SET bIsDeleted = 1
    WHERE sMaCauHoi IN (SELECT sMaCauHoi FROM tblCauHoi WHERE sMaBaiHoc = @sMaBaiHoc);

    UPDATE tblCauHoi
    SET bIsDeleted = 1
    WHERE sMaBaiHoc = @sMaBaiHoc;

    UPDATE tblBangKetQua
    SET fDiem = NULL  -- Xóa điểm nếu cần
    WHERE sMaBaiHoc = @sMaBaiHoc;

    UPDATE tblBaiHoc
    SET bIsDeleted = 1
    WHERE sMaBaiHoc = @sMaBaiHoc;

    PRINT 'Xóa bài học thành công!';
END;

create proc pr_SuaBaiHoc
	@sMaBaiHoc varchar(10),
	@sTenBaiHoc nvarchar(max)
as
begin
	update tblBaiHoc
	set sTenBaiHoc = @sMaBaiHoc
	where sMaBaiHoc = @sTenBaiHoc;
end;

create proc pr_AddBaiHoc
	@sMaBaiHoc varchar(10),
	@sTenBaiHoc nvarchar(max)
as
begin
	if exists (select 1 from tblBaiHoc where sMaBaiHoc = @sMaBaiHoc)
	begin
		RAISERROR ('Mã bài học đã tồn tại!', 16, 1);
        RETURN;
	end
	insert into tblBaiHoc(sMaBaiHoc, sTenBaiHoc)
	values(@sMaBaiHoc, @sTenBaiHoc)
end;

create proc pr_AddBaiHocWithExistID
	@sMaBaiHoc varchar(10),
	@sTenBaiHoc nvarchar(max)
as
begin
	update tblBaiHoc
	set sTenBaiHoc = @sTenBaiHoc, bIsDeleted = 0
	where sMaBaiHoc = @sMaBaiHoc and bIsDeleted = 1
end;

create proc dskhcb
	@tenTK VARCHAR(50)
AS
BEGIN
    SELECT 
        kh.sMaKhoaHoc, 
        kh.sTenKhoaHoc,
        dkh.bTrangThaiHoc
    FROM tblTaiKhoan tk
    INNER JOIN tblDanhSachKhoaHocDangKy dkh ON tk.iMaTK = dkh.iMaTK
    INNER JOIN tblKhoaHoc kh ON dkh.sMaKhoaHoc = kh.sMaKhoaHoc
    WHERE tk.sTenTK = @tenTK
        AND dkh.bIsDeleted = 0
        AND kh.bIsDeleted = 0;
END;


CREATE PROC DSCau_hoi
(
	@mabaihoc VARCHAR(10)
)
AS
BEGIN
	SELECT *  FROM tblCauHoi
	WHERE sMaBaiHoc = @mabaihoc
END


--TRIGGER AND PROC NINH

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tg_sumScore]
ON [dbo].[tblBangTraLoi]
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    
    PRINT 'Trigger tg_sumScore đã chạy!';
    
    UPDATE bk
    SET fDiem = ISNULL((
        SELECT COUNT(tl.sMaTraLoi) * 2
        FROM tblBangTraLoi tl
        WHERE tl.sMaKetQua = bk.sMaKetQua
        AND tl.bDapAnDung = 1
    ), 0)  -- Nếu kết quả NULL, đặt về 0
    FROM tblBangKetQua bk
    JOIN inserted i ON bk.sMaKetQua = i.sMaKetQua;
END;
GO
ALTER TABLE [dbo].[tblBangTraLoi] ENABLE TRIGGER [tg_sumScore]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pr_createResult]
@MaKetQua varchar(10),
@MaTaiKhoan int,
@MaBaiHoc varchar(10)
as
	insert into tblBangKetQua(sMaKetQua,iMaTK,sMaBaiHoc)
	values (@MaKetQua, @MaTaiKhoan, @MaBaiHoc)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pr_createResultDetail]
@MaKetQua varchar(10),
@MaTraLoi varchar(10),
@MaCauHoi varchar(10),
@MaDapAnTraLoi varchar(10),
@DapAnDung bit
as
	insert into tblBangTraLoi(sMaTraLoi,sMaKetQua,sMaCauHoi,sMaDapAnTraLoi,bDapAnDung)
	values (@MaTraLoi,@MaKetQua,@MaCauHoi,@MaDapAnTraLoi,@DapAnDung)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pr_finishTest]
@MaKetQua VARCHAR(10),
@ThoiGianNop DATETIME
as
	UPDATE tblBangKetQua
    SET dThoiGianNop = @ThoiGianNop
    WHERE sMaKetQua = @MaKetQua;
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[pr_getResult]
@MaTK int,
@MaBaiHoc VARCHAR(10)
AS
	select * from tblBangKetQua as kq
	where kq.iMaTK = @MaTK and kq.sMaBaiHoc LIKE @MaBaiHoc
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[pr_loadQuestion]
@MaBaiHoc VARCHAR(10)
as
begin
	SELECT * 
	FROM tblCauHoi
	JOIN tblDapAn ON tblCauHoi.sMaCauHoi = tblDapAn.sMaCauHoi
	WHERE tblCauHoi.sMaBaiHoc LIKE @MaBaiHoc
	ORDER BY tblCauHoi.sMaCauHoi ASC;
end
GO

create proc pr_countSoKetQua
  @MaTK INT
  as
  BEGIN
    select count(sMaKetQua) from tblBangKetQua
    where tblBangKetQua.iMaTK = @MaTK 
    end

-- của toản
CREATE PROC check_login
(
	@stentk VARCHAR(50),
	@smatkhau VARCHAR(50)
)
AS
BEGIN
	IF NOT EXISTS (SELECT 1 FROM tblTaiKhoan WHERE sTenTK = @stentk)
	BEGIN
		SELECT -1 AS ktr, NULL AS bCheckAdmin;
		RETURN;
	END
	
	DECLARE @bCheckAdmin BIT;
	
	IF EXISTS (SELECT 1 FROM tblTaiKhoan WHERE sTenTK = @stentk AND sMatKhau = @smatkhau)
	BEGIN
		SELECT @bCheckAdmin = bCheckAdmin FROM tblTaiKhoan WHERE sTenTK = @stentk;
		SELECT 1 AS ktr, @bCheckAdmin AS bCheckAdmin;
	END
	ELSE
	BEGIN
		SELECT 0 AS ktr, NULL AS bCheckAdmin;
	END
END


-- Hàm đăng nhập tài khoản
CREATE PROC insert_data_login
(
	@stentk VARCHAR(50),
	@semail VARCHAR(MAX),
	@smatkhau VARCHAR(50)
)
AS
BEGIN
	INSERT INTO tblTaiKhoan(sTenTK, sEmail, sMatKhau)
	VALUES (@stentk, @semail, @smatkhau)
END

------
CREATE PROC LayBaiHoc
(
	@tentk VARCHAR (50)
)
AS
BEGIN
	SELECT TOP 4 sTenBaiHoc FROM tblBaiHoc, tblBangKetQua, tblTaiKhoan WHERE tblBaiHoc.sMaBaiHoc = tblBangKetQua.sMaBaiHoc AND tblBangKetQua.iMaTK = tblTaiKhoan.iMaTK AND tblTaiKhoan.sTenTK = @tentk
END


------
CREATE PROC LayKetQuaBaiLam
(
	@tentk VARCHAR (50)
)
AS
BEGIN
	SELECT tblTaiKhoan.sTenTK AS 'Tên tài khoản',
		tblBaiHoc.sTenBaiHoc AS 'Tên bài học',
		tblBangKetQua.dThoiGianNop AS 'Thời gian nộp',
		tblBangKetQua.fDiem AS 'Điểm'
	FROM tblBaiHoc, tblBangKetQua, tblTaiKhoan
	WHERE tblBaiHoc.sMaBaiHoc = tblBangKetQua.sMaBaiHoc
	AND tblBangKetQua.iMaTK = tblTaiKhoan.iMaTK
	AND tblTaiKhoan.sTenTK = @tentk
END


CREATE PROC LayKetQuaBaiHoc
(
	@tentk VARCHAR(50),
	@tenBaiHoc NVARCHAR(100)
)
AS
BEGIN
	SELECT tblTaiKhoan.sTenTK AS 'Tên tài khoản', 
		   tblBaiHoc.sTenBaiHoc AS 'Tên bài học', 
		   tblBangKetQua.dThoiGianNop AS 'Thời gian nộp', 
		   tblBangKetQua.fDiem AS 'Điểm'
	FROM tblBaiHoc, tblBangKetQua, tblTaiKhoan
	WHERE tblBaiHoc.sMaBaiHoc = tblBangKetQua.sMaBaiHoc 
	  AND tblBangKetQua.iMaTK = tblTaiKhoan.iMaTK 
	  AND tblTaiKhoan.sTenTK = @tentk
	  AND tblBaiHoc.sTenBaiHoc = @tenBaiHoc

END




create proc pr_init_account
@stentk varchar(50),
@smatkhau VARCHAR(50)
AS
    BEGIN
        select * from tblTaiKhoan
        where sTenTK like @stentk
        and sMatKhau like @smatkhau
    END

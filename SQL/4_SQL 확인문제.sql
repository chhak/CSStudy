#날짜 : 2022/07/19
#이름 : 김철학
#내용 : SQL 확인문제

#실습 4-1
CREATE TABLE `tbl_member` (
	`memberID`			VARCHAR(10) PRIMARY KEY,
	`memberName`		VARCHAR(10) NOT NULL,
	`memberHp`	      CHAR(13),
	`memberAge`	      TINYINT,
	`memberAddr`	   VARCHAR(20)
);

CREATE TABLE `tbl_product` (
	`productCode`	INT AUTO_INCREMENT PRIMARY KEY,
	`productName`	VARCHAR(10) NOT NULL,
	`price`			INT NOT NULL,
	`amount`	   	INT NOT NULL DEFAULT 0,
	`company`		VARCHAR(10),
	`makeDate`		DATE
);

#실습 4-2
INSERT INTO `tbl_member` VALUES ('p101', '김유신', '010-1234-1001', 25, '신라');
INSERT INTO `tbl_member` VALUES ('p102', '김춘추', '010-1234-1002', 23, '신라');
INSERT INTO `tbl_member` VALUES ('p103', '장보고', NULL, 31, '통일신라');
INSERT INTO `tbl_member` VALUES ('p104', '강감찬', NULL, NULL, '고려');
INSERT INTO `tbl_member` VALUES ('p105', '이순신', '010-1234-1005', 50, NULL);

INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('냉장고',   800,  10, 'LG', '2022-01-06');
INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('노트북',  1200,  20, '삼성', '2022-01-06');
INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('TV',      1400,   6, 'LG', '2022-01-06');
INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('세탁기',  1000,   8, 'LG', '2022-01-06');
INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('컴퓨터',  1100,   0, NULL, NULL);
INSERT INTO `tbl_product` (`productName`, `price`, `amount`, `company`, `makeDate`) VALUES ('휴대폰',   900, 102, '삼성', '2022-01-06');


#실습 4-3

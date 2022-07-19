#날짜 : 2022/07/19
#이름 : 김철학
#내용 : 테이블 설정

#실습하기 2-1
CREATE TABLE `User2` (
	`uid`  VARCHAR(10) PRIMARY KEY,
	`name` VARCHAR(10),
	`hp`   CHAR(13),
	`age`  INT
);

INSERT INTO `User2` VALUES ('a101', '김유신', '010-1234-1001', 25);
INSERT INTO `User2` VALUES ('a102', '김춘추', '010-1234-1002', 23);
INSERT INTO `User2` VALUES ('a103', '장보고', '010-1234-1003', 35);
INSERT INTO `User2` VALUES ('a104', '강감찬', '010-1234-1004', 45);
INSERT INTO `User2` VALUES ('a105', '이순신', '010-1234-1005', 55);
INSERT INTO `User2` VALUES ('a106', '정약용', '010-1234-1003', 33);

#실습하기 2-2
CREATE TABLE `User3` (
	`uid`  VARCHAR(10) PRIMARY KEY,
	`name` VARCHAR(10),
	`hp`   CHAR(13) UNIQUE,
	`age`  INT
);

INSERT INTO `User3` VALUES ('a101', '김유신', '010-1234-1001', 25);
INSERT INTO `User3` VALUES ('a102', '김춘추', '010-1234-1002', 23);
INSERT INTO `User3` VALUES ('a103', '장보고', '010-1234-1003', 35);
INSERT INTO `User3` VALUES ('a104', '강감찬', '010-1234-1004', 45);
INSERT INTO `User3` VALUES ('a105', '이순신', '010-1234-1005', 55);
INSERT INTO `User3` VALUES ('a106', '정약용', '010-1234-1006', 33);

#실습하기 2-3
CREATE TABLE `Parent` (
	`pid`   VARCHAR(10) PRIMARY KEY,
	`name`  VARCHAR(10),
	`hp`	  CHAR(13) UNIQUE
);

CREATE TABLE `Child` (
	`cid` VARCHAR(10) PRIMARY KEY,
	`name` VARCHAR(10),
	`hp`	  CHAR(13) UNIQUE,
	`pid`   VARCHAR(10),
	FOREIGN KEY (`pid`) REFERENCES `Parent` (`pid`)
);

INSERT INTO `Parent` VALUES ('p101', '김유신', '010-1234-1001');
INSERT INTO `Parent` VALUES ('p102', '김춘추', '010-1234-1002');
INSERT INTO `Parent` VALUES ('p103', '장보고', '010-1234-1003');

INSERT INTO `Child` VALUES ('c101', '김길동', '010-1010-1001', 'p101');
INSERT INTO `Child` VALUES ('c102', '김길순', '010-1010-1002', 'p101');
INSERT INTO `Child` VALUES ('c103', '장길동', '010-1010-1003', 'p103');
INSERT INTO `Child` VALUES ('c104', '홍길동', '010-1010-1003', 'p105');

#실습하기 2-4
CREATE TABLE `User4` (
	`seq`     INT AUTO_INCREMENT PRIMARY KEY,
	`name`	 VARCHAR(10),
	`gender`	 TINYINT,
	`age`		 INT,
	`addr`	 VARCHAR(255)
);

INSERT INTO `User4` (`name`, `gender`, `age`, `addr`) VALUES ('김유신',   1, 25, '김해시');
INSERT INTO `User4` (`name`, `gender`, `age`, `addr`) VALUES ('김춘추',   1, 22, '경주시');
INSERT INTO `User4` (`name`, `gender`, `age`, `addr`) VALUES ('장보고',   1, 35, '완도군');
INSERT INTO `User4` (`name`, `gender`, `age`, `addr`) VALUES ('신사임당', 2, 42, '강릉시');
INSERT INTO `User4` (`name`, `gender`, `age`, `addr`) VALUES ('이순신',   1, 55, '서울시');
INSERT INTO `User4` SET `addr` = '부산시';

#실습하기 2-5
CREATE TABLE `User5` (
	`seq`     INT AUTO_INCREMENT PRIMARY KEY,
	`name`	 VARCHAR(10) NOT NULL,
	`gender`	 TINYINT DEFAULT 0,
	`age`		 INT DEFAULT 1,
	`addr`	 VARCHAR(255)
);

INSERT INTO `User5` (`name`, `gender`, `age`, `addr`) VALUES ('김유신',   1, 25, '김해시');
INSERT INTO `User5` (`name`, `gender`, `age`, `addr`) VALUES ('김춘추',   1, 22, '경주시');
INSERT INTO `User5` (`name`, `gender`, `age`, `addr`) VALUES ('장보고',   1, 35, '완도군');
INSERT INTO `User5` (`name`, `gender`, `age`, `addr`) VALUES ('신사임당', 2, 42, '강릉시');
INSERT INTO `User5` (`name`, `gender`, `age`, `addr`) VALUES ('이순신',   1, 55, '서울시');
INSERT INTO `User5` SET `name`='송상현', `addr` = '부산시';

#실습하기 2-6
CREATE TABLE `User6` LIKE `User5`;

#실습하기 2-7
INSERT INTO `User6` SELECT * FROM `User5`;
INSERT INTO `User6` (`name`, `gender`, `age`, `addr`) SELECT `name`, `gender`, `age`, `addr` FROM `User5`;

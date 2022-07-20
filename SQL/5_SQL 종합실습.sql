#날짜 : 2022/07/20
#이름 : 김철학
#내용 : SQL 종합실습

#실습 5-1
CREATE DATABASE `SaleDB`;
CREATE USER 'manager'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON `SaleDB`.* TO 'manager'@'%';
FLUSH PRIVILEGES;

#실습 5-2
CREATE TABLE `Member` (
	`uid`		VARCHAR(10) PRIMARY KEY,
	`name`	VARCHAR(10) NOT NULL,
	`hp`		CHAR(13) UNIQUE NOT NULL,
	`pos`		VARCHAR(10) NOT NULL,
	`dep`		TINYINT,
	`rdate`	DATETIME  NOT NULL
);

CREATE TABLE `Department` (
	`depNo`	TINYINT PRIMARY KEY,
	`name`	VARCHAR(10) NOT NULL,
	`tel`		CHAR(12) NOT NULL
);

CREATE TABLE `Sales` (
	`seq`		INT AUTO_INCREMENT PRIMARY KEY,
	`uid`		VARCHAR(10) NOT NULL,
	`year`	YEAR NOT NULL,
	`month`	TINYINT NOT NULL,
	`sale`	INT NOT NULL
);

#실습 5-3
INSERT INTO `Member` VALUES ('a101', '박혁거세', '010-1234-1001', '부장', 101, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a102', '김유신',   '010-1234-1002', '차장', 101, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a103', '김춘추',   '010-1234-1003', '사원', 101, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a104', '장보고',   '010-1234-1004', '대리', 102, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a105', '강감찬',   '010-1234-1005', '과장', 102, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a106', '이성계',   '010-1234-1006', '차장', 103, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a107', '정철',     '010-1234-1007', '차장', 103, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a108', '이순신',   '010-1234-1008', '부장', 104, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a109', '허균',     '010-1234-1009', '부장', 104, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a110', '정약용',   '010-1234-1010', '사원', 105, '2020-11-19 11:39:48');
INSERT INTO `Member` VALUES ('a111', '박지원',   '010-1234-1011', '사원', 105, '2020-11-19 11:39:48');

INSERT INTO `Department` VALUES (101, '영업1부', '051-512-1001');
INSERT INTO `Department` VALUES (102, '영업2부', '051-512-1002');
INSERT INTO `Department` VALUES (103, '영업3부', '051-512-1003');
INSERT INTO `Department` VALUES (104, '영업4부', '051-512-1004');
INSERT INTO `Department` VALUES (105, '영업5부', '051-512-1005');
INSERT INTO `Department` VALUES (106, '영업지원부', '051-512-1006');
INSERT INTO `Department` VALUES (107, '인사부', '051-512-1007');

INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a101', 2018, 1,  98100);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2018, 1, 136000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2018, 1,  80100);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2018, 1,  78000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2018, 1,  93000);

INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a101', 2018, 2,  23500);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2018, 2, 126000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2018, 2,  18500);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2018, 2,  19000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a106', 2018, 2,  53000);

INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a101', 2019, 1,  24000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2019, 1, 109000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2019, 1, 101000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2019, 1,  53500);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a107', 2019, 1,  24000);

INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2019, 2, 160000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2019, 2, 101000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2019, 2,  43000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2019, 2,  24000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a106', 2019, 2, 109000);

INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2020, 1, 201000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2020, 1,  63000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2020, 1,  74000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a106', 2020, 1, 122000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a107', 2020, 1, 111000);

INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a102', 2020, 2, 120000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a103', 2020, 2,  93000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a104', 2020, 2,  84000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a105', 2020, 2, 180000);
INSERT INTO `Sales` (`uid`, `year`, `month`, `sale`) VALUES ('a108', 2020, 2,  76000);

#실습 5-4
SELECT * FROM `Member` WHERE `name`='김유신';
SELECT * FROM `Member` WHERE `name` != '김춘추';
SELECT * FROM `Member` WHERE `name` <> '김춘추';
SELECT * FROM `Member` WHERE `pos` = '사원' OR `pos` = '대리';
SELECT * FROM `Member` WHERE `pos` IN('사원', '대리');
SELECT * FROM `Member` WHERE `name` LIKE '%신';
SELECT * FROM `Member` WHERE `name` LIKE '정_';

#실습 5-5
SELECT * FROM `Sales` ORDER BY `sale`;
SELECT * FROM `Sales` ORDER BY `sale` ASC;
SELECT * FROM `Sales` ORDER BY `sale` DESC;

SELECT * FROM `Sales` 
WHERE `sale` > 50000 
ORDER BY `year`, `month`, `sale` DESC;


#실습 5-6
SELECT * FROM `sales` LIMIT 3;
SELECT * FROM `sales` LIMIT 0, 3;
SELECT * FROM `sales` LIMIT 1, 3;
SELECT * FROM `sales` LIMIT 4, 5;

SELECT * FROM `Sales` 
WHERE `sale` > 50000
ORDER BY `year` DESC, `month` ASC, `sale` DESC
LIMIT 5;

#실습 5-7
SELECT SUM(`sale`) AS `합계` FROM `Sales`;
SELECT AVG(`sale`) AS `평균` FROM `Sales`;
SELECT COUNT(*) AS `갯수` FROM `Sales`;
SELECT SUBSTRING(`hp`, 10, 4) AS `전화번호 끝자리` FROM `Member`;
INSERT INTO `Member` VALUES ('b101','을지문덕', '010-5555-1234', '사장', 107, NOW());

#확인1. 2018년 1월 매출의 총합을 구하시오.
SELECT SUM(`sale`) AS `2018년 1월 총합` 
FROM `Sales` 
WHERE `year`=2018 AND `month`=1;

#확인2. 2019년 2월달에 5만원 이상 매출에 대한 총합과 평균을 구하시오.
SELECT
	SUM(`sale`) AS `총합`,
	AVG(`sale`) AS `평균`
FROM
	`Sales`
WHERE
	`year`=2019 AND `month`=2 AND `sale` >= 50000;

#확인3. 2020년 전체 매출 가운데 최저, 최고, 매출을 구하시오.
SELECT 
	MIN(`sale`) AS `최저`,
	MAX(`sale`) AS `최고`
FROM
	`Sales`
WHERE
	`year` IN(2020);

#실습 5-8
SELECT * FROM `Sales` GROUP BY `uid`;
SELECT * FROM `Sales` GROUP BY `year`;
SELECT * FROM `Sales` GROUP BY `uid`, `year`;
SELECT `uid`, COUNT(*) AS `건수` FROM `Sales` GROUP BY `uid`;
SELECT `uid`, SUM(`sale`) AS `합계` FROM `Sales` GROUP BY `uid`;
SELECT `uid`, AVG(`sale`) AS `평균` FROM `Sales` GROUP BY `uid`;

#실습 5-9
SELECT `uid`, SUM(`sale`) AS `합계` FROM `Sales` 
GROUP BY `uid`
HAVING `합계` >= 200000;

SELECT `uid`, `year`, SUM(`sale`) AS `합계` FROM `Sales` 
WHERE `sale` >= 100000
GROUP BY `uid`, `year`
HAVING `합계` >= 200000
ORDER BY `합계` DESC;

#실습 5-10
CREATE TABLE `Sales2` LIKE `Sales`;
INSERT INTO `Sales2` SELECT * FROM `Sales`;
UPDATE `Sales2` SET `year` = `year` + 3;

SELECT * FROM `Sales` UNION SELECT * FROM `Sales2`;

#실습 5-11
#실습 5-12
SELECT * FROM `Sales` AS a
JOIN `Member` AS b
ON a.uid = b.uid;

SELECT a.`seq`, a.`uid`, `sale`, `name`, `pos` FROM `Sales` AS a
JOIN `Member` AS b
ON a.uid = b.uid;

SELECT a.`seq`, a.`uid`, `sale`, `name`, `pos` FROM `Sales` AS a
JOIN `Member` AS b
USING(`uid`);

SELECT * FROM `Sales` AS a
JOIN `Member` 			 AS b ON a.uid = b.uid
JOIN `Department` 	 AS c ON b.dep = c.depNo;

#실습 5-13

#확인1. 모든 직원의 아이디, 이름, 직급, 부서명을 조회하시오.
SELECT `uid`, a.`name`, `pos`, b.`name` FROM `Member` AS a
JOIN `Department` AS b
ON a.`dep` = b.`depNo`;

SELECT `uid`, a.`name`, `pos`, b.`name` 
FROM `Member` AS a, `Department` AS b
WHERE a.dep = b.depNo;

#확인2. '김유신'직원의 2019년도 매출의 합을 조회하시오.
SELECT SUM(`sale`) AS `2019년 매출합`
FROM `Member` AS a
JOIN `Sales` AS b
ON a.uid = b.uid
WHERE a.`name` = '김유신' AND `year`=2019;

#확인3. 2019년 50,000이상의 매출에 대해 직원별 매출의 합이 100,000원 이상인 직원의
#이름, 부서명, 직급, 년도, 매출 합을 조회하시오. 단, 매출 합이 큰 순서부터 정렬
SELECT b.`name`, c.`name`, b.`pos`, `year`, SUM(`sale`) AS `매출합`
FROM `Sales`   AS a
JOIN `Member` AS b ON a.uid=b.uid
JOIN `Department` AS c ON b.dep=c.depNo
WHERE `sale` >= 50000 AND `year`=2019
GROUP BY a.`uid`
HAVING `매출합` >= 100000
ORDER BY `매출합` DESC;




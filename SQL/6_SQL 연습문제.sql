#날짜 : 2022/07/21
#이름 : 김철학
#내용 : SQL 연습문제

#실습 6-1
CREATE DATABASE `OrderDB`;
CREATE USER 'master'@'%' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON `OrderDB`.* TO 'master'@'%';
FLUSH PRIVILEGES;

#실습 6-2
CREATE TABLE `Customer` (
	`custId` VARCHAR(10) PRIMARY KEY,
	`name`   VARCHAR(10) NOT NULL,
	`hp`		CHAR(13) DEFAULT NULL,
	`addr`   VARCHAR(100) DEFAULT NULL,
	`rdate`	DATE NOT NULL
);

CREATE TABLE `Product` (
	`prodNo`		INT AUTO_INCREMENT PRIMARY KEY,
	`prodName`  VARCHAR(10) NOT NULL,
	`stock`		INT DEFAULT 0,
	`price`		INT DEFAULT NULL,
	`company`   VARCHAR(20) NOT NULL
);

CREATE TABLE `Order` (
	`orderNo`		INT AUTO_INCREMENT PRIMARY KEY,
	`orderId`      VARCHAR(10) NOT NULL,
	`orderProduct` INT NOT NULL,
	`orderCount`	INT DEFAULT 1,
	`orderDate`    DATETIME NOT NULL
);

#실습 6-3
INSERT INTO `Customer` VALUES ('kimys', '김유신', '010-1234-1001', '김해시 봉황동', '2022-01-01');
INSERT INTO `Customer` VALUES ('kimcc', '김춘추', '010-1234-1002', '경주시 보문동', '2022-01-02');
INSERT INTO `Customer` VALUES ('jang', '장보고', '010-1234-1003', '완도군 청산면', '2022-01-03');
INSERT INTO `Customer` VALUES ('kang', '강감찬', '010-1234-1004', '서울시 마포구', '2022-01-04');
INSERT INTO `Customer` (`custid`, `name`, `rdate`) VALUES ('leesg', '이성계', '2022-01-05');
INSERT INTO `Customer` VALUES ('jeongc', '정철', '010-1234-1006', '경기도 용인시', '2022-01-06');
INSERT INTO `Customer` (`custid`, `name`, `rdate`) VALUES ('heoj', '허준', '2022-01-07');
INSERT INTO `Customer` VALUES ('leess', '이순신', '010-1234-1008', '서울시 영등포구', '2022-01-08');
INSERT INTO `Customer` VALUES ('songsh', '송상현', '010-1234-1009', '부산시 동래구', '2022-01-09');
INSERT INTO `Customer` VALUES ('jeongyy', '정약용', '010-1234-1010', '경기도 광주시', '2022-01-10');

INSERT INTO `Product` VALUES (1, '새우깡',   5000, 1500, '농심');
INSERT INTO `Product` VALUES (2, '초코파이', 2500, 2500, '오리온');
INSERT INTO `Product` VALUES (3, '포카칩',   3600, 1700, '오리온');
INSERT INTO `Product` VALUES (4, '양파링',   1250, 1800, '농심');
INSERT INTO `Product` (`prodNo`, `prodName`, `stock`, `company`) VALUES (5, '죠리퐁',   2200, '크라운');
INSERT INTO `Product` VALUES (6, '마카렛트', 3500, 3500, '롯데');
INSERT INTO `Product` VALUES (7, '뿌셔뿌셔', 1650, 1200, '오뚜기');

INSERT INTO `Order` VALUES (1,  'kimcc',  3, 2, '2022-07-01 13:15:10');
INSERT INTO `Order` VALUES (2,  'kimys',  4, 1, '2022-07-01 14:16:11');
INSERT INTO `Order` VALUES (3,  'leess',  1, 1, '2022-07-01 17:23:18');
INSERT INTO `Order` VALUES (4,  'songsh', 6, 5, '2022-07-02 10:46:36');
INSERT INTO `Order` VALUES (5,  'kimcc',  2, 1, '2022-07-03 09:15:37');
INSERT INTO `Order` VALUES (6,  'kimys',  7, 3, '2022-07-03 12:35:12');
INSERT INTO `Order` VALUES (7,  'jeongyy', 1, 2, '2022-07-03 16:55:36');
INSERT INTO `Order` VALUES (8,  'kang',    2, 4, '2022-07-04 14:23:23');
INSERT INTO `Order` VALUES (9,  'kimcc', 1, 3, '2022-07-04 21:54:34');
INSERT INTO `Order` VALUES (10, 'heoj',  6, 1, '2022-07-05 14:21:03');

#실습 6-4. 고객 테이블에 존재하는 모든 속성을 조회 하시오.
SELECT * FROM `Customer`;

#실습 6-5. 고객 테이블에서 고객 아이디, 이름, 휴대폰 번호를 조회 하시오.
SELECT `custid`, `name`, `hp` FROM `Customer`;

#실습 6-6. 제품 테이블에 존재하는 모든 속성을 조회 하시오.
SELECT * FROM `product`;

#실습 6-7. 제품 테이블에서 제조업체를 조회 하시오.
SELECT `company` FROM `product`;

#실습 6-8. 제품 테이블에서 제조업체를 중복 없이 조회 하시오.
SELECT DISTINCT `company` FROM `product`;

#실습 6-9. 제품 테이블에서 제품명과 단가를 조회 하시오.
SELECT `prodName`, `price` FROM `product`;

#실습 6-10. 제품 테이블에서 제품명과 단가를 조회하되, 단가에 500원을 더해 '조정단가'로 출력 하시오.
SELECT `prodName`, `price` + 500 AS `조정단가` FROM `product`;

#실습 6-11. 제품 테이블에서 오리온이 제조한 제품의 제품명, 재고량, 단가를 조회 하시오.
SELECT `prodName`, `stock`, `price` FROM `product` WHERE `company` = '오리온';

#실습 6-12. 주문 테이블에서 'kimcc' 고객이 주문한 주문제품, 수량, 주문일자를 조회하시오.
SELECT `orderProduct`, `orderCount`, `orderDate` FROM `order` WHERE `orderid` = 'kimcc';

#실습 6-13. 주문 테이블에서 'kimcc' 고객이 2개이상 주문한 주문제품, 수량, 주문일자를 조회하시오.
SELECT `orderProduct`, `orderCount`, `orderDate` FROM `order` WHERE `orderid` = 'kimcc' AND `orderCount` >= 2;

#실습 6-14. 제품 테이블에서 단가가 1,000원 이상 2,000원 이하인 제품을 조회하시오.
SELECT * FROM `product` WHERE `price` >= 1000 AND `price` <= 2000;

#실습 6-15. 고객 테이블에서 성이 김씨인 고객의 아이디, 이름, 휴대폰, 주소를 조회하시오.
SELECT `custid`, `name`, `hp`, `addr` FROM `customer` WHERE `name` LIKE '김%';

#실습 6-16. 고객 테이블에서 고객 아이디가 4자인 고객의 아이디, 이름, 휴대폰, 주소를 조회하시오.
SELECT `custid`, `name`, `hp`, `addr` FROM `customer` WHERE `custid` LIKE '____';

#실습 6-17. 고객 테이블에서 휴대폰 번호가 입력되지 않은 고객을 조회하시오.
SELECT * FROM `customer` WHERE `hp` IS NULL;

#실습 6-18. 고객 테이블에서 주소가 입력된 고객을 조회하시오.
SELECT * FROM `customer` WHERE `addr` IS NOT NULL;

#실습 6-19. 고객 테이블에서 가입일을 내림차순으로 정렬하여 고객을 조회하시오.
SELECT * FROM `customer` ORDER BY `rdate` DESC;

#실습 6-20. 주문 테이블에서 수량이 3개이상인 주문내용을 조회하시오. 단 주문수량으로 내림차순 정렬하고, 수량이 같으면 제품번호를 기준으로 오름차순 정렬하시오.
SELECT * FROM `order` WHERE `orderCount` >= 3 ORDER BY `orderCount` DESC, `orderProduct` ASC;

#실습 6-21. 제품 테이블에서 모든 제품의 단가 평균을 조회하시오.
SELECT AVG(`price`) FROM `product`;

#실습 6-22. 농심에서 제조한 제품의 재고량 합계를 조회하시오.
SELECT SUM(`stock`) AS `재고량 합계` FROM `product` WHERE `company`='농심';

#실습 6-23. 고객 테이블에 고객이 몇 명 등록되어 있는지 조회하시오.
SELECT COUNT(`custid`) AS `고객수` FROM `customer`;

#실습 6-24. 제품 테이블에서 제조업체의 수를 조회하시오.
SELECT COUNT(DISTINCT `company`) AS `제조업체 수` FROM `product`;

#실습 6-25. 주문 테이블에서 주문제품별 수량의 합계를 조회하시오.
SELECT `orderProduct` AS `주문 상품번호`, SUM(`orderCount`) AS `총 주문수량` FROM `order` GROUP BY `orderProduct`;

#실습 6-26. 제품 테이블에서 제조업체별 제조한 제품의 개수와 제품 중 가장 비싼 단가를 조회하시오.
SELECT `company` AS `제조업체`, COUNT(*) AS `제품수`, MAX(`price`) AS `최고가` FROM `product` GROUP BY `company`;

#실습 6-27. 제품 테이블에서 제품을 2개 이상 제조한 제조업체별로 제품의 개수와 제품 중 가장 비싼 단가를 조회하시오.
SELECT `company` AS `제조업체`, COUNT(*) AS `제품수`, MAX(`price`) AS `최고가` FROM `product` GROUP BY `company` HAVING `제품수` >= 2;

#실습 6-28. 주문테이블에서 각 주문고객이 주문한 제품의 총 주문수량을 주문 제품별로 조회하시오.
SELECT `orderProduct`, `orderId`, SUM(`orderCount`) AS `총 주문수량` FROM `order` GROUP BY `orderProduct`, `orderId`;

#실습 6-29. 'kimcc' 고객이 주문한 제품의 이름을 조회하시오.
SELECT a.orderId, b.prodName FROM `order` AS a
JOIN `product` AS b
ON a.orderProduct = b.prodNo
WHERE `orderid` = 'kimcc';

#실습 6-30. 주문일자가 7월 3일인 고객의 아이디, 이름, 상품명 그리고 주문 날짜시간을  조회하시오.
SELECT `orderid`, `name`, `prodName`, `orderDate` FROM `order` AS a
JOIN `customer` AS b
ON a.orderId = b.custId
JOIN `product` AS c
ON a.orderProduct = c.prodNo
WHERE SUBSTR(`orderDate`, 1, 10) = '2022-07-03';


/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 80018
Source Host           : localhost:3306
Source Database       : hotelmgr

Target Server Type    : MYSQL
Target Server Version : 80018
File Encoding         : 65001

Date: 2019-12-13 21:02:59
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for check_in_information
-- ----------------------------
DROP TABLE IF EXISTS `check_in_information`;
CREATE TABLE `check_in_information` (
  `Room_Number` char(4) NOT NULL,
  `ID` char(18) NOT NULL,
  `Check_In_Time` datetime NOT NULL,
  PRIMARY KEY (`Room_Number`,`ID`),
  KEY `ID` (`ID`),
  CONSTRAINT `check_in_information_ibfk_1` FOREIGN KEY (`Room_Number`) REFERENCES `room_information` (`Room_Number`),
  CONSTRAINT `check_in_information_ibfk_2` FOREIGN KEY (`ID`) REFERENCES `client_information` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of check_in_information
-- ----------------------------

-- ----------------------------
-- Table structure for client_information
-- ----------------------------
DROP TABLE IF EXISTS `client_information`;
CREATE TABLE `client_information` (
  `ID` char(18) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Phone_Number` char(11) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of client_information
-- ----------------------------

-- ----------------------------
-- Table structure for member_information
-- ----------------------------
DROP TABLE IF EXISTS `member_information`;
CREATE TABLE `member_information` (
  `Phone_Number` char(11) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `RTime` date NOT NULL,
  PRIMARY KEY (`Phone_Number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of member_information
-- ----------------------------
INSERT INTO `member_information` VALUES ('13603062923', 'Gorden', '2019-12-13');

-- ----------------------------
-- Table structure for reserve_information
-- ----------------------------
DROP TABLE IF EXISTS `reserve_information`;
CREATE TABLE `reserve_information` (
  `Phone_Number` char(11) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Room_Type` char(20) NOT NULL,
  `Check_In_Time` datetime NOT NULL,
  PRIMARY KEY (`Phone_Number`),
  KEY `Room_Type` (`Room_Type`),
  CONSTRAINT `reserve_information_ibfk_1` FOREIGN KEY (`Room_Type`) REFERENCES `room_price_information` (`Room_Type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of reserve_information
-- ----------------------------

-- ----------------------------
-- Table structure for room_information
-- ----------------------------
DROP TABLE IF EXISTS `room_information`;
CREATE TABLE `room_information` (
  `Room_Number` char(4) NOT NULL,
  `Room_Type` char(20) NOT NULL,
  `Room_State` char(4) NOT NULL,
  PRIMARY KEY (`Room_Number`),
  KEY `Room_Type` (`Room_Type`),
  CONSTRAINT `room_information_ibfk_1` FOREIGN KEY (`Room_Type`) REFERENCES `room_price_information` (`Room_Type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of room_information
-- ----------------------------

-- ----------------------------
-- Table structure for room_price_information
-- ----------------------------
DROP TABLE IF EXISTS `room_price_information`;
CREATE TABLE `room_price_information` (
  `Room_Type` char(20) NOT NULL,
  `Room_Price` char(6) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`Room_Type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of room_price_information
-- ----------------------------

-- ----------------------------
-- Table structure for settle_bill_information
-- ----------------------------
DROP TABLE IF EXISTS `settle_bill_information`;
CREATE TABLE `settle_bill_information` (
  `Number` char(20) NOT NULL,
  `Room_Number` char(4) NOT NULL,
  `Room_Type` char(20) NOT NULL,
  `Room_Price` char(6) NOT NULL,
  `Check_In_Time` datetime NOT NULL,
  `Check_Out_Time` datetime NOT NULL,
  `Total_Consume` char(6) NOT NULL,
  PRIMARY KEY (`Number`),
  KEY `Room_Number` (`Room_Number`),
  CONSTRAINT `settle_bill_information_ibfk_1` FOREIGN KEY (`Room_Number`) REFERENCES `room_information` (`Room_Number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of settle_bill_information
-- ----------------------------

-- ----------------------------
-- Table structure for staff_information
-- ----------------------------
DROP TABLE IF EXISTS `staff_information`;
CREATE TABLE `staff_information` (
  `Staff_Number` char(4) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Name` varchar(20) NOT NULL,
  `ID` char(18) NOT NULL,
  `Phone_Number` char(11) NOT NULL,
  `Job` varchar(20) NOT NULL,
  `Room_In_Charge` char(4) NOT NULL,
  PRIMARY KEY (`Staff_Number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of staff_information
-- ----------------------------

-- ----------------------------
-- Table structure for system_user_information
-- ----------------------------
DROP TABLE IF EXISTS `system_user_information`;
CREATE TABLE `system_user_information` (
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of system_user_information
-- ----------------------------
INSERT INTO `system_user_information` VALUES ('admin', 'admin');
INSERT INTO `system_user_information` VALUES ('Gorden', 'gorden51');

-- ----------------------------
-- Table structure for ticket_information
-- ----------------------------
DROP TABLE IF EXISTS `ticket_information`;
CREATE TABLE `ticket_information` (
  `Ticket_Type` char(2) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Ticket_Price` char(6) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`Ticket_Type`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ticket_information
-- ----------------------------
INSERT INTO `ticket_information` VALUES ('标准', '20');
INSERT INTO `ticket_information` VALUES ('赠送', '0');

-- ----------------------------
-- Table structure for ticket_sell_information
-- ----------------------------
DROP TABLE IF EXISTS `ticket_sell_information`;
CREATE TABLE `ticket_sell_information` (
  `Sell_Time` datetime NOT NULL,
  `Room_Number` char(4) NOT NULL,
  `Ticket_Type` char(2) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Ticket_Price` char(6) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Total` varchar(6) NOT NULL,
  PRIMARY KEY (`Sell_Time`),
  KEY `Room_Number` (`Room_Number`),
  CONSTRAINT `ticket_sell_information_ibfk_1` FOREIGN KEY (`Room_Number`) REFERENCES `room_information` (`Room_Number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of ticket_sell_information
-- ----------------------------

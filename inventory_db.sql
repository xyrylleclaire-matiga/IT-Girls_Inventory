-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 02, 2025 at 05:06 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbladmin_users`
--

CREATE TABLE `tbladmin_users` (
  `admin_id` int(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `Middle_Name` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `assigned_department` enum('Bookstore Department') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbladmin_users`
--

INSERT INTO `tbladmin_users` (`admin_id`, `username`, `LastName`, `FirstName`, `Middle_Name`, `Password`, `assigned_department`) VALUES
(12344321, 'Marasigan', 'Morales', 'Reynaldo', 'M', 'REYNALDO', ''),
(67899876, 'Morales', 'Morales', 'Maria Dionesia', 'L', 'DIONESIA', 'Bookstore Department');

-- --------------------------------------------------------

--
-- Table structure for table `tbluniformlogs`
--

CREATE TABLE `tbluniformlogs` (
  `log_id` int(11) NOT NULL,
  `uniform_id` int(50) NOT NULL,
  `action` enum('Add Item','Update Item','Pullout','Delete Item') NOT NULL,
  `Reason` varchar(100) NOT NULL,
  `changed_quantity` varchar(50) NOT NULL,
  `previous_quantity` varchar(11) DEFAULT NULL,
  `new_quantity` varchar(11) DEFAULT NULL,
  `admin_id` int(50) NOT NULL,
  `action_date` datetime NOT NULL,
  `item_name` varchar(100) DEFAULT NULL,
  `level` varchar(50) DEFAULT NULL,
  `gender` varchar(20) DEFAULT NULL,
  `size` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbluniforms`
--

CREATE TABLE `tbluniforms` (
  `uniform_id` int(11) NOT NULL,
  `item_name` varchar(50) NOT NULL,
  `category` enum('School Uniform','PE Uniform','Corporate Attire') NOT NULL,
  `level` enum('Kindergarten','Elementary','Junior High','Senior High','College') NOT NULL,
  `gender` enum('Male','Female','Unisex') NOT NULL,
  `size` enum('Extra Small','Small','Medium','Large','Extra Large','2XL','3XL','4XL','5XL','6XL') NOT NULL,
  `stock_quantity` int(50) NOT NULL,
  `price` decimal(50,0) NOT NULL,
  `status` enum('Available','Out of Stock','Critical','') NOT NULL,
  `date_added` datetime NOT NULL,
  `date_updated` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluniforms`
--

INSERT INTO `tbluniforms` (`uniform_id`, `item_name`, `category`, `level`, `gender`, `size`, `stock_quantity`, `price`, `status`, `date_added`, `date_updated`) VALUES
(1, 'Slacks', 'School Uniform', 'College', 'Male', 'Extra Small', 2, 450, 'Critical', '2025-10-07 11:28:08', NULL),
(2, 'Polo', 'School Uniform', 'College', 'Male', 'Extra Small', 0, 450, 'Out of Stock', '2025-10-07 11:29:07', NULL),
(3, 'Skirt', 'School Uniform', 'College', 'Female', 'Extra Small', 3, 470, 'Critical', '2025-10-07 11:30:01', NULL),
(4, 'Polo', 'School Uniform', 'College', 'Female', 'Extra Small', 15, 420, 'Available', '2025-10-07 11:30:31', NULL),
(5, 'Slacks', 'School Uniform', 'College', 'Male', 'Small', 10, 470, 'Available', '2025-10-07 11:30:31', NULL),
(6, 'Polo', 'School Uniform', 'College', 'Male', 'Small', 5, 470, 'Critical', '2025-10-07 11:31:23', NULL),
(7, 'Skirt', 'School Uniform', 'College', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 11:31:23', NULL),
(8, 'Polo', 'School Uniform', 'College', 'Female', 'Small', 15, 470, 'Available', '2025-10-07 11:31:23', NULL),
(9, 'Slacks', 'School Uniform', 'College', 'Male', 'Medium', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(10, 'Polo', 'School Uniform', 'College', 'Male', 'Medium', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(11, 'Skirt', 'School Uniform', 'College', 'Female', 'Medium', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(12, 'Polo', 'School Uniform', 'College', 'Female', 'Medium', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(13, 'Slacks', 'School Uniform', 'College', 'Male', 'Large', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(14, 'Polo', 'School Uniform', 'College', 'Male', 'Large', 12, 470, 'Available', '2025-10-07 11:31:23', NULL),
(15, 'Skirt', 'School Uniform', 'College', 'Female', 'Large', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(16, 'Polo', 'School Uniform', 'College', 'Female', 'Large', 11, 450, 'Available', '2025-10-07 11:31:23', NULL),
(17, 'Slacks', 'School Uniform', 'College', 'Male', 'Extra Large', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(18, 'Polo', 'School Uniform', 'College', 'Male', 'Extra Large', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(19, 'Skirt', 'School Uniform', 'College', 'Female', 'Extra Large', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(20, 'Polo', 'School Uniform', 'College', 'Female', 'Extra Large', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(21, 'Slacks', 'School Uniform', 'College', 'Male', '2XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(22, 'Polo', 'School Uniform', 'College', 'Male', '2XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(23, 'Skirt', 'School Uniform', 'College', 'Female', '2XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(24, 'Polo', 'School Uniform', 'College', 'Female', '2XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(25, 'Slacks', 'School Uniform', 'College', 'Male', '3XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(26, 'Polo', 'School Uniform', 'College', 'Male', '3XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(27, 'Skirt', 'School Uniform', 'College', 'Female', '3XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(28, 'Polo', 'School Uniform', 'College', 'Female', '3XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(29, 'Slacks', 'School Uniform', 'College', 'Male', '4XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(30, 'Polo', 'School Uniform', 'College', 'Male', '4XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(31, 'Skirt', 'School Uniform', 'College', 'Female', '4XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(32, 'Polo', 'School Uniform', 'College', 'Female', '4XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(33, 'Slacks', 'School Uniform', 'College', 'Male', '5XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(34, 'Polo', 'School Uniform', 'College', 'Male', '5XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(35, 'Skirt', 'School Uniform', 'College', 'Female', '5XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(36, 'Polo', 'School Uniform', 'College', 'Female', '5XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(37, 'Slacks', 'School Uniform', 'College', 'Male', '6XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(38, 'Polo', 'School Uniform', 'College', 'Male', '6XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(39, 'Skirt', 'School Uniform', 'College', 'Female', '6XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(40, 'Polo', 'School Uniform', 'College', 'Female', '6XL', 10, 470, 'Available', '2025-10-07 11:31:23', NULL),
(41, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(42, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(43, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(44, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(45, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(46, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(47, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(48, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(49, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(50, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(51, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(52, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(53, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(54, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(55, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(56, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(57, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(58, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(59, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(60, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 11:44:03', NULL),
(61, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:50:08', NULL),
(62, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:50:08', NULL),
(63, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:51:03', NULL),
(64, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 11:51:03', NULL),
(65, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(66, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(67, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(68, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(69, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(70, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(71, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(72, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(73, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(74, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(75, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(76, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(77, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(78, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(79, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(80, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(81, 'Slacks', 'School Uniform', 'Senior High', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(82, 'Polo', 'School Uniform', 'Senior High', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(83, 'Skirt', 'School Uniform', 'Senior High', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(84, 'Polo', 'School Uniform', 'Senior High', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(85, 'Slacks', 'School Uniform', 'Senior High', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(86, 'Polo', 'School Uniform', 'Senior High', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(87, 'Skirt', 'School Uniform', 'Senior High', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(88, 'Polo', 'School Uniform', 'Senior High', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(89, 'Slacks', 'School Uniform', 'Senior High', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(90, 'Polo', 'School Uniform', 'Senior High', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(91, 'Skirt', 'School Uniform', 'Senior High', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(92, 'Polo', 'School Uniform', 'Senior High', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(93, 'Slacks', 'School Uniform', 'Senior High', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(94, 'Polo', 'School Uniform', 'Senior High', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(95, 'Skirt', 'School Uniform', 'Senior High', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(96, 'Polo', 'School Uniform', 'Senior High', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(97, 'Slacks', 'School Uniform', 'Senior High', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(98, 'Polo', 'School Uniform', 'Senior High', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(99, 'Skirt', 'School Uniform', 'Senior High', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(100, 'Polo', 'School Uniform', 'Senior High', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 11:51:58', NULL),
(101, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:01:04', NULL),
(102, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:01:04', NULL),
(103, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(104, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(105, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(106, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(107, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(108, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(109, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(110, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(111, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(112, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(113, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(114, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(115, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(116, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(117, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(118, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(119, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(120, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:06:39', NULL),
(121, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(122, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(123, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(124, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(125, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(126, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(127, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(128, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(129, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(130, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(131, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(132, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(133, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(134, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(135, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(136, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(137, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(138, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(139, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(140, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(141, 'Slacks', 'School Uniform', 'Junior High', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(142, 'Polo', 'School Uniform', 'Junior High', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(143, 'Skirt', 'School Uniform', 'Junior High', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(144, 'Polo', 'School Uniform', 'Junior High', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(145, 'Slacks', 'School Uniform', 'Junior High', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(146, 'Polo', 'School Uniform', 'Junior High', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(147, 'Skirt', 'School Uniform', 'Junior High', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(148, 'Polo', 'School Uniform', 'Junior High', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(149, 'Slacks', 'School Uniform', 'Junior High', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(150, 'Polo', 'School Uniform', 'Junior High', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(151, 'Skirt', 'School Uniform', 'Junior High', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(152, 'Polo', 'School Uniform', 'Junior High', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(153, 'Slacks', 'School Uniform', 'Junior High', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(154, 'Polo', 'School Uniform', 'Junior High', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(155, 'Skirt', 'School Uniform', 'Junior High', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(156, 'Polo', 'School Uniform', 'Junior High', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(157, 'Slacks', 'School Uniform', 'Junior High', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(158, 'Polo', 'School Uniform', 'Junior High', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(159, 'Skirt', 'School Uniform', 'Junior High', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(160, 'Polo', 'School Uniform', 'Junior High', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:10:35', NULL),
(161, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(162, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(163, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(164, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(165, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(166, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(167, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(168, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(169, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(170, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(171, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(172, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(173, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(174, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(175, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(176, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(177, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(178, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(179, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(180, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:18:22', NULL),
(181, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(182, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(185, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(186, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(187, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(188, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(189, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(190, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Small', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(191, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(192, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(193, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(194, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Medium', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(195, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(196, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(197, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(198, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Large', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(199, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(200, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(201, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(202, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(203, 'Blouse', 'School Uniform', 'Elementary', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(204, 'Jumper', 'School Uniform', 'Elementary', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(205, 'Polo', 'School Uniform', 'Elementary', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(206, 'Pants', 'School Uniform', 'Elementary', 'Male', '2XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(207, 'Blouse', 'School Uniform', 'Elementary', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(208, 'Jumper', 'School Uniform', 'Elementary', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(209, 'Polo', 'School Uniform', 'Elementary', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(210, 'Pants', 'School Uniform', 'Elementary', 'Male', '3XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(211, 'Blouse', 'School Uniform', 'Elementary', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(212, 'Jumper', 'School Uniform', 'Elementary', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(213, 'Polo', 'School Uniform', 'Elementary', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(214, 'Pants', 'School Uniform', 'Elementary', 'Male', '4XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(215, 'Blouse', 'School Uniform', 'Elementary', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(216, 'Jumper', 'School Uniform', 'Elementary', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(217, 'Polo', 'School Uniform', 'Elementary', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(218, 'Pants', 'School Uniform', 'Elementary', 'Male', '5XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(219, 'Blouse', 'School Uniform', 'Elementary', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(220, 'Jumper', 'School Uniform', 'Elementary', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(221, 'Polo', 'School Uniform', 'Elementary', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(222, 'Pants', 'School Uniform', 'Elementary', 'Male', '6XL', 10, 450, 'Available', '2025-10-07 12:21:54', NULL),
(223, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '', 10, 450, 'Available', '2025-10-07 12:30:34', NULL),
(224, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(225, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(226, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Small', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(227, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Small', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(228, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Medium', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(229, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Medium', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(230, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Large', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(231, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Large', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(232, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(233, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(234, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '2XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(235, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '2XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(236, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '3XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(237, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '3XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(238, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '4XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(239, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '4XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(240, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '5XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(241, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '5XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(242, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '6XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(243, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '6XL', 10, 470, 'Available', '2025-10-07 12:32:30', NULL),
(244, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(245, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(246, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Small', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(247, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Small', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(248, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Medium', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(249, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Medium', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(250, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Large', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(251, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Large', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(252, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(253, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(254, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '2XL', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(255, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '2XL', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(256, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '3XL', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(257, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '3XL', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(258, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '4XL', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(259, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '4XL', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(260, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '5XL', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(261, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '5XL', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(262, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '6XL', 10, 450, 'Available', '2025-10-07 12:41:52', NULL),
(263, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '6XL', 10, 470, 'Available', '2025-10-07 12:41:52', NULL),
(264, 'Polo', 'School Uniform', 'Kindergarten', 'Male', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(265, 'Slacks', 'School Uniform', 'Kindergarten', 'Male', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(266, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Extra Small', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(267, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Extra Small', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(268, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Small', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(269, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Small', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(270, 'Polo', 'School Uniform', 'Kindergarten', '', 'Small', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(271, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Small', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(272, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Medium', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(273, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Medium', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(274, 'Polo', 'School Uniform', 'Kindergarten', '', 'Medium', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(275, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Medium', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(276, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Large', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(277, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Large', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(278, 'Polo', 'School Uniform', 'Kindergarten', '', 'Large', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(279, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Large', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(280, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(281, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(282, 'Polo', 'School Uniform', 'Kindergarten', '', 'Extra Large', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(283, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Extra Large', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(284, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '2XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(285, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '2XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(286, 'Polo', 'School Uniform', 'Kindergarten', '', '2XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(287, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '2XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(288, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '3XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(289, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '3XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(290, 'Polo', 'School Uniform', 'Kindergarten', '', '3XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(291, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '3XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(292, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '4XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(293, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '4XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(294, 'Polo', 'School Uniform', 'Kindergarten', '', '4XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(295, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '4XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(296, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '5XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(297, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '5XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(298, 'Polo', 'School Uniform', 'Kindergarten', '', '5XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(299, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '5XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(300, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '6XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(301, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '6XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(302, 'Polo', 'School Uniform', 'Kindergarten', '', '6XL', 10, 450, 'Available', '2025-10-07 12:46:08', NULL),
(303, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '6XL', 10, 470, 'Available', '2025-10-07 12:46:08', NULL),
(305, 'HSHS', 'PE Uniform', 'Junior High', 'Male', 'Medium', 12, 123, 'Available', '2025-11-01 17:19:47', NULL),
(319, 'hahhah', 'School Uniform', 'Elementary', 'Unisex', 'Medium', 909, 121, 'Available', '2025-11-02 12:08:39', NULL),
(330, 'jajaj', 'PE Uniform', 'Elementary', 'Male', 'Small', 100, 100, 'Available', '2025-11-02 21:09:49', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `user_id` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `role` enum('Admin','Student') NOT NULL,
  `email` varchar(50) NOT NULL,
  `status` enum('Active','Deactivated') NOT NULL,
  `attempts` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`user_id`, `last_name`, `first_name`, `middle_name`, `password`, `role`, `email`, `status`, `attempts`) VALUES
('1878-23', 'Saguban', 'Bianca Jeanelle', 'Tuazon', 'SAGUBAN', 'Student', 'biancaa@gmail.com', 'Active', 3),
('1881-23', 'Obis', 'Francine Mei', 'Ramirez', 'OBIS', 'Student', 'francine@gmail.com', 'Active', 3),
('2008-23', 'Cenardo', 'Vernalyn', 'Equing', 'CENARDO', 'Student', 'vernalyn@gmail.com', 'Active', 3),
('2097-23', 'Matiga', 'Xyrylle Claire', 'Lasin', 'MATIGA', 'Student', 'xyryllematiga@gmail.com', 'Active', 3);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pullouts`
--

CREATE TABLE `tbl_pullouts` (
  `PulloutId` int(11) NOT NULL,
  `uniform_id` int(11) NOT NULL,
  `PulloutReason` enum('Damaged','Misprinted') NOT NULL,
  `Date` datetime NOT NULL,
  `Quantity` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pullouts`
--

INSERT INTO `tbl_pullouts` (`PulloutId`, `uniform_id`, `PulloutReason`, `Date`, `Quantity`) VALUES
(8, 8, 'Misprinted', '2025-10-22 00:00:00', 1),
(9, 8, 'Misprinted', '2025-10-22 00:00:00', 1),
(10, 8, '', '0000-00-00 00:00:00', 0),
(11, 8, '', '0000-00-00 00:00:00', 0),
(12, 8, '', '0000-00-00 00:00:00', 0),
(13, 6, 'Damaged', '2025-10-22 00:00:00', 1),
(14, 10, 'Damaged', '2025-10-22 17:42:07', 2),
(15, 4, 'Misprinted', '2025-10-22 17:47:13', 0),
(16, 1, 'Damaged', '2025-10-22 18:54:11', 2),
(17, 1, 'Damaged', '2025-10-22 18:58:48', 11),
(18, 1, 'Damaged', '2025-10-22 19:05:35', 11),
(19, 1, 'Damaged', '2025-10-22 19:05:35', 2),
(20, 1, 'Damaged', '2025-10-22 19:09:16', 11),
(21, 1, 'Damaged', '2025-10-22 19:09:16', 2),
(22, 1, 'Misprinted', '2025-10-22 19:14:59', 12),
(23, 1, 'Misprinted', '2025-10-22 19:14:59', 2),
(24, 1, 'Misprinted', '2025-10-22 20:39:45', 1),
(25, 1, 'Misprinted', '2025-10-22 20:39:45', 4),
(26, 1, 'Damaged', '2025-10-22 20:43:04', 2),
(27, 2, 'Damaged', '2025-10-22 20:49:31', 2),
(28, 3, 'Damaged', '2025-10-22 21:00:04', -2),
(29, 4, 'Misprinted', '2025-10-22 21:00:36', 0),
(30, 3, 'Damaged', '2025-10-22 21:03:03', -2),
(31, 3, 'Damaged', '2025-10-22 21:03:27', 0),
(32, 1, 'Damaged', '2025-10-23 11:17:19', 1),
(33, 1, 'Misprinted', '2025-10-23 11:18:07', 2),
(34, 1, '', '2025-11-01 16:48:10', 1),
(35, 1, 'Damaged', '2025-11-01 16:55:49', 1),
(36, 1, 'Misprinted', '2025-11-01 19:56:20', 11),
(37, 4, 'Misprinted', '2025-11-01 19:57:07', 9),
(38, 1, 'Damaged', '2025-11-01 19:58:14', 9),
(39, 2, 'Damaged', '2025-11-01 20:00:47', 5),
(40, 1, 'Misprinted', '2025-11-01 20:01:42', 50),
(41, 1, 'Damaged', '2025-11-01 21:42:26', 10),
(42, 4, 'Misprinted', '2025-11-01 22:53:58', 5),
(43, 3, 'Damaged', '2025-11-02 12:21:27', 1),
(44, 1, 'Damaged', '2025-11-02 12:22:17', 10),
(45, 1, 'Misprinted', '2025-11-02 12:27:42', 3),
(46, 3, 'Damaged', '2025-11-02 12:27:57', 1),
(47, 2, 'Damaged', '2025-11-02 12:30:54', 10),
(48, 6, 'Misprinted', '2025-11-02 12:39:19', 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbladmin_users`
--
ALTER TABLE `tbladmin_users`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `tbluniformlogs`
--
ALTER TABLE `tbluniformlogs`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `admin_id` (`admin_id`),
  ADD KEY `uniform_id` (`uniform_id`);

--
-- Indexes for table `tbluniforms`
--
ALTER TABLE `tbluniforms`
  ADD PRIMARY KEY (`uniform_id`),
  ADD UNIQUE KEY `unique_uniform_combo` (`item_name`,`category`,`level`,`gender`,`size`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`user_id`);

--
-- Indexes for table `tbl_pullouts`
--
ALTER TABLE `tbl_pullouts`
  ADD PRIMARY KEY (`PulloutId`),
  ADD KEY `uniform_id` (`uniform_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbladmin_users`
--
ALTER TABLE `tbladmin_users`
  MODIFY `admin_id` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=67899877;

--
-- AUTO_INCREMENT for table `tbluniformlogs`
--
ALTER TABLE `tbluniformlogs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbluniforms`
--
ALTER TABLE `tbluniforms`
  MODIFY `uniform_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=331;

--
-- AUTO_INCREMENT for table `tbl_pullouts`
--
ALTER TABLE `tbl_pullouts`
  MODIFY `PulloutId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbluniformlogs`
--
ALTER TABLE `tbluniformlogs`
  ADD CONSTRAINT `tbluniformlogs_ibfk_1` FOREIGN KEY (`admin_id`) REFERENCES `tbladmin_users` (`admin_id`),
  ADD CONSTRAINT `tbluniformlogs_ibfk_2` FOREIGN KEY (`uniform_id`) REFERENCES `tbluniforms` (`uniform_id`);

--
-- Constraints for table `tbl_pullouts`
--
ALTER TABLE `tbl_pullouts`
  ADD CONSTRAINT `tbl_pullouts_ibfk_1` FOREIGN KEY (`uniform_id`) REFERENCES `tbluniforms` (`uniform_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

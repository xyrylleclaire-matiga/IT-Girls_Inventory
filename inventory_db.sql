-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 03, 2025 at 03:37 AM
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

--
-- Dumping data for table `tbluniformlogs`
--

INSERT INTO `tbluniformlogs` (`log_id`, `uniform_id`, `action`, `Reason`, `changed_quantity`, `previous_quantity`, `new_quantity`, `admin_id`, `action_date`, `item_name`, `level`, `gender`, `size`) VALUES
(1, 652, 'Add Item', 'New Uniform Design', '120', '0', '120', 12344321, '2025-11-03 10:16:32', 'hahah', 'Elementary', 'Unisex', 'Medium'),
(2, 652, 'Pullout', 'Misprinted', '-100', '120', '20', 12344321, '2025-11-03 10:16:54', NULL, NULL, NULL, NULL),
(3, 652, 'Update Item', 'Price Adjustment', '-10', '20', '10', 12344321, '2025-11-03 10:17:27', NULL, NULL, NULL, NULL),
(4, 652, 'Delete Item', 'Duplicate Entry', '-20', '20', '0', 12344321, '2025-11-03 10:33:43', 'hahah', 'Elementary', 'Unisex', 'Medium'),
(5, 653, 'Add Item', 'New Supplier Item', '123', '0', '123', 12344321, '2025-11-03 10:34:43', 'HAHAHHA', 'Elementary', 'Male', 'Small'),
(6, 654, 'Add Item', 'New Supplier Item', '12', '0', '12', 12344321, '2025-11-03 10:35:44', 'hahah', 'Elementary', 'Male', 'Small'),
(7, 654, 'Delete Item', 'Duplicate Entry', '-12', '12', '0', 12344321, '2025-11-03 10:36:14', 'hahah', 'Elementary', 'Male', 'Small'),
(8, 653, 'Delete Item', 'Duplicate Entry', '-123', '123', '0', 12344321, '2025-11-03 10:36:51', 'HAHAHHA', 'Elementary', 'Male', 'Small');

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
  `Course` varchar(50) NOT NULL,
  `date_added` datetime NOT NULL,
  `date_updated` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbluniforms`
--

INSERT INTO `tbluniforms` (`uniform_id`, `item_name`, `category`, `level`, `gender`, `size`, `stock_quantity`, `price`, `status`, `Course`, `date_added`, `date_updated`) VALUES
(1, 'Slacks', 'School Uniform', 'College', 'Male', 'Extra Small', 0, 470, 'Out of Stock', '0', '2025-10-07 11:28:08', NULL),
(2, 'Polo', 'School Uniform', 'College', 'Male', 'Extra Small', 6, 470, 'Available', '0', '2025-10-07 11:29:07', '2025-10-30 20:22:15'),
(3, 'Skirt', 'School Uniform', 'College', 'Female', 'Extra Small', 4, 470, 'Critical', '0', '2025-10-07 11:30:01', '2025-10-30 16:39:54'),
(4, 'Polo', 'School Uniform', 'College', 'Female', 'Extra Small', 10, 470, 'Available', '0', '2025-10-07 11:30:31', NULL),
(5, 'Slacks', 'School Uniform', 'College', 'Male', 'Small', 10, 470, 'Available', '0', '2025-10-07 11:30:31', NULL),
(6, 'Polo', 'School Uniform', 'College', 'Male', 'Small', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(7, 'Skirt', 'School Uniform', 'College', 'Female', 'Small', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(8, 'Polo', 'School Uniform', 'College', 'Female', 'Small', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(9, 'Slacks', 'School Uniform', 'College', 'Male', 'Medium', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(10, 'Polo', 'School Uniform', 'College', 'Male', 'Medium', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(11, 'Skirt', 'School Uniform', 'College', 'Female', 'Medium', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(12, 'Polo', 'School Uniform', 'College', 'Female', 'Medium', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(13, 'Slacks', 'School Uniform', 'College', 'Male', 'Large', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(14, 'Polo', 'School Uniform', 'College', 'Male', 'Large', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(15, 'Skirt', 'School Uniform', 'College', 'Female', 'Large', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(16, 'Polo', 'School Uniform', 'College', 'Female', 'Large', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(17, 'Slacks', 'School Uniform', 'College', 'Male', 'Extra Large', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(18, 'Polo', 'School Uniform', 'College', 'Male', 'Extra Large', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(19, 'Skirt', 'School Uniform', 'College', 'Female', 'Extra Large', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(20, 'Polo', 'School Uniform', 'College', 'Female', 'Extra Large', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(21, 'Slacks', 'School Uniform', 'College', 'Male', '2XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(22, 'Polo', 'School Uniform', 'College', 'Male', '2XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(23, 'Skirt', 'School Uniform', 'College', 'Female', '2XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(24, 'Polo', 'School Uniform', 'College', 'Female', '2XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(25, 'Slacks', 'School Uniform', 'College', 'Male', '3XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(26, 'Polo', 'School Uniform', 'College', 'Male', '3XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(27, 'Skirt', 'School Uniform', 'College', 'Female', '3XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(28, 'Polo', 'School Uniform', 'College', 'Female', '3XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(29, 'Slacks', 'School Uniform', 'College', 'Male', '4XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(30, 'Polo', 'School Uniform', 'College', 'Male', '4XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(31, 'Skirt', 'School Uniform', 'College', 'Female', '4XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(32, 'Polo', 'School Uniform', 'College', 'Female', '4XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(33, 'Slacks', 'School Uniform', 'College', 'Male', '5XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(34, 'Polo', 'School Uniform', 'College', 'Male', '5XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(35, 'Skirt', 'School Uniform', 'College', 'Female', '5XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(36, 'Polo', 'School Uniform', 'College', 'Female', '5XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(37, 'Slacks', 'School Uniform', 'College', 'Male', '6XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(38, 'Polo', 'School Uniform', 'College', 'Male', '6XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(39, 'Skirt', 'School Uniform', 'College', 'Female', '6XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(40, 'Polo', 'School Uniform', 'College', 'Female', '6XL', 10, 470, 'Available', '0', '2025-10-07 11:31:23', NULL),
(41, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(42, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(43, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Small', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(44, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Small', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(45, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Medium', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(46, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Medium', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(47, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Large', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(48, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Large', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(49, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(50, 'PE Pants', 'PE Uniform', 'College', 'Unisex', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(51, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '2XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(52, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '2XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(53, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '3XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(54, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '3XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(55, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '4XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(56, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '4XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(57, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '5XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(58, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '5XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(59, 'PE Shirt', 'PE Uniform', 'College', 'Unisex', '6XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(60, 'PE Pants', 'PE Uniform', 'College', 'Unisex', '6XL', 10, 450, 'Available', '0', '2025-10-07 11:44:03', NULL),
(61, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 11:50:08', NULL),
(62, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 11:50:08', NULL),
(63, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 11:51:03', NULL),
(64, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 11:51:03', NULL),
(65, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Small', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(66, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Small', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(67, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Small', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(68, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Small', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(69, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Medium', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(70, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Medium', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(71, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Medium', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(72, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Medium', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(73, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Large', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(74, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Large', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(75, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Large', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(76, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Large', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(77, 'Slacks', 'School Uniform', 'Senior High', 'Male', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(78, 'Polo', 'School Uniform', 'Senior High', 'Male', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(79, 'Skirt', 'School Uniform', 'Senior High', 'Female', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(80, 'Polo', 'School Uniform', 'Senior High', 'Female', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(81, 'Slacks', 'School Uniform', 'Senior High', 'Male', '2XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(82, 'Polo', 'School Uniform', 'Senior High', 'Male', '2XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(83, 'Skirt', 'School Uniform', 'Senior High', 'Female', '2XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(84, 'Polo', 'School Uniform', 'Senior High', 'Female', '2XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(85, 'Slacks', 'School Uniform', 'Senior High', 'Male', '3XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(86, 'Polo', 'School Uniform', 'Senior High', 'Male', '3XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(87, 'Skirt', 'School Uniform', 'Senior High', 'Female', '3XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(88, 'Polo', 'School Uniform', 'Senior High', 'Female', '3XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(89, 'Slacks', 'School Uniform', 'Senior High', 'Male', '4XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(90, 'Polo', 'School Uniform', 'Senior High', 'Male', '4XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(91, 'Skirt', 'School Uniform', 'Senior High', 'Female', '4XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(92, 'Polo', 'School Uniform', 'Senior High', 'Female', '4XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(93, 'Slacks', 'School Uniform', 'Senior High', 'Male', '5XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(94, 'Polo', 'School Uniform', 'Senior High', 'Male', '5XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(95, 'Skirt', 'School Uniform', 'Senior High', 'Female', '5XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(96, 'Polo', 'School Uniform', 'Senior High', 'Female', '5XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(97, 'Slacks', 'School Uniform', 'Senior High', 'Male', '6XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(98, 'Polo', 'School Uniform', 'Senior High', 'Male', '6XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(99, 'Skirt', 'School Uniform', 'Senior High', 'Female', '6XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(100, 'Polo', 'School Uniform', 'Senior High', 'Female', '6XL', 10, 450, 'Available', '0', '2025-10-07 11:51:58', NULL),
(101, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:01:04', NULL),
(102, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:01:04', NULL),
(103, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(104, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(105, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(106, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(107, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(108, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(109, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(110, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(111, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(112, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(113, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(114, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(115, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(116, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(117, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(118, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(119, 'PE Shirt', 'PE Uniform', 'Senior High', 'Unisex', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(120, 'PE Pants', 'PE Uniform', 'Senior High', 'Unisex', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:06:39', NULL),
(121, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(122, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(123, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(124, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(125, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(126, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(127, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(128, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(129, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(130, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(131, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(132, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(133, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(134, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(135, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(136, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(137, 'Slacks', 'School Uniform', 'Junior High', 'Male', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(138, 'Polo', 'School Uniform', 'Junior High', 'Male', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(139, 'Skirt', 'School Uniform', 'Junior High', 'Female', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(140, 'Polo', 'School Uniform', 'Junior High', 'Female', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(141, 'Slacks', 'School Uniform', 'Junior High', 'Male', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(142, 'Polo', 'School Uniform', 'Junior High', 'Male', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(143, 'Skirt', 'School Uniform', 'Junior High', 'Female', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(144, 'Polo', 'School Uniform', 'Junior High', 'Female', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(145, 'Slacks', 'School Uniform', 'Junior High', 'Male', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(146, 'Polo', 'School Uniform', 'Junior High', 'Male', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(147, 'Skirt', 'School Uniform', 'Junior High', 'Female', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(148, 'Polo', 'School Uniform', 'Junior High', 'Female', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(149, 'Slacks', 'School Uniform', 'Junior High', 'Male', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(150, 'Polo', 'School Uniform', 'Junior High', 'Male', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(151, 'Skirt', 'School Uniform', 'Junior High', 'Female', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(152, 'Polo', 'School Uniform', 'Junior High', 'Female', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(153, 'Slacks', 'School Uniform', 'Junior High', 'Male', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(154, 'Polo', 'School Uniform', 'Junior High', 'Male', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(155, 'Skirt', 'School Uniform', 'Junior High', 'Female', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(156, 'Polo', 'School Uniform', 'Junior High', 'Female', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(157, 'Slacks', 'School Uniform', 'Junior High', 'Male', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(158, 'Polo', 'School Uniform', 'Junior High', 'Male', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(159, 'Skirt', 'School Uniform', 'Junior High', 'Female', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(160, 'Polo', 'School Uniform', 'Junior High', 'Female', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:10:35', NULL),
(161, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Small', 9, 450, 'Available', '0', '2025-10-07 12:18:22', '2025-10-30 20:21:45'),
(162, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(163, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(164, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(165, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(166, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(167, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(168, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(169, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(170, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(171, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(172, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(173, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(174, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(175, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(176, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(177, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(178, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(179, 'PE Shirt', 'PE Uniform', 'Junior High', 'Unisex', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(180, 'PE Pants', 'PE Uniform', 'Junior High', 'Unisex', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:18:22', NULL),
(181, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(182, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(185, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(186, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(187, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(188, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(189, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(190, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(191, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(192, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(193, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(194, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(195, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(196, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(197, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(198, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(199, 'Blouse', 'School Uniform', 'Elementary', 'Female', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(200, 'Jumper', 'School Uniform', 'Elementary', 'Female', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(201, 'Polo', 'School Uniform', 'Elementary', 'Male', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(202, 'Pants', 'School Uniform', 'Elementary', 'Male', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(203, 'Blouse', 'School Uniform', 'Elementary', 'Female', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(204, 'Jumper', 'School Uniform', 'Elementary', 'Female', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(205, 'Polo', 'School Uniform', 'Elementary', 'Male', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(206, 'Pants', 'School Uniform', 'Elementary', 'Male', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(207, 'Blouse', 'School Uniform', 'Elementary', 'Female', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(208, 'Jumper', 'School Uniform', 'Elementary', 'Female', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(209, 'Polo', 'School Uniform', 'Elementary', 'Male', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(210, 'Pants', 'School Uniform', 'Elementary', 'Male', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(211, 'Blouse', 'School Uniform', 'Elementary', 'Female', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(212, 'Jumper', 'School Uniform', 'Elementary', 'Female', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(213, 'Polo', 'School Uniform', 'Elementary', 'Male', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(214, 'Pants', 'School Uniform', 'Elementary', 'Male', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(215, 'Blouse', 'School Uniform', 'Elementary', 'Female', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(216, 'Jumper', 'School Uniform', 'Elementary', 'Female', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(217, 'Polo', 'School Uniform', 'Elementary', 'Male', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(218, 'Pants', 'School Uniform', 'Elementary', 'Male', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(219, 'Blouse', 'School Uniform', 'Elementary', 'Female', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(220, 'Jumper', 'School Uniform', 'Elementary', 'Female', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(221, 'Polo', 'School Uniform', 'Elementary', 'Male', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(222, 'Pants', 'School Uniform', 'Elementary', 'Male', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:21:54', NULL),
(223, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '', 10, 450, 'Available', '0', '2025-10-07 12:30:34', NULL),
(224, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Small', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(225, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Small', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(226, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Small', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(227, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Small', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(228, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Medium', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(229, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Medium', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(230, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Large', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(231, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Large', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(232, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Large', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(233, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', 'Extra Large', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(234, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '2XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(235, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '2XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(236, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '3XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(237, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '3XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(238, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '4XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(239, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '4XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(240, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '5XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(241, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '5XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(242, 'PE Shirt', 'PE Uniform', 'Elementary', 'Unisex', '6XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(243, 'PE Pants', 'PE Uniform', 'Elementary', 'Unisex', '6XL', 10, 470, 'Available', '0', '2025-10-07 12:32:30', NULL),
(244, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(245, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Small', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(246, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(247, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Small', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(248, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(249, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Medium', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(250, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(251, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Large', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(252, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(253, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', 'Extra Large', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(254, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(255, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '2XL', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(256, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(257, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '3XL', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(258, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(259, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '4XL', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(260, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(261, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '5XL', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(262, 'PE Shirt', 'PE Uniform', 'Kindergarten', 'Unisex', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:41:52', NULL),
(263, 'PE Pants', 'PE Uniform', 'Kindergarten', 'Unisex', '6XL', 10, 470, 'Available', '0', '2025-10-07 12:41:52', NULL),
(264, 'Polo', 'School Uniform', 'Kindergarten', 'Male', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(265, 'Slacks', 'School Uniform', 'Kindergarten', 'Male', 'Extra Small', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(266, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Extra Small', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(267, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Extra Small', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(268, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(269, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Small', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(270, 'Polo', 'School Uniform', 'Kindergarten', '', 'Small', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(271, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Small', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(272, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(273, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Medium', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(274, 'Polo', 'School Uniform', 'Kindergarten', '', 'Medium', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(275, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Medium', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(276, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(277, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Large', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(278, 'Polo', 'School Uniform', 'Kindergarten', '', 'Large', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(279, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Large', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(280, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(281, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', 'Extra Large', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(282, 'Polo', 'School Uniform', 'Kindergarten', '', 'Extra Large', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(283, 'Pants', 'School Uniform', 'Kindergarten', 'Male', 'Extra Large', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(284, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(285, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '2XL', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(286, 'Polo', 'School Uniform', 'Kindergarten', '', '2XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(287, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '2XL', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(288, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(289, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '3XL', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(290, 'Polo', 'School Uniform', 'Kindergarten', '', '3XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(291, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '3XL', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(292, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(293, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '4XL', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(294, 'Polo', 'School Uniform', 'Kindergarten', '', '4XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(295, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '4XL', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(296, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(297, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '5XL', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(298, 'Polo', 'School Uniform', 'Kindergarten', '', '5XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(299, 'Pants', 'School Uniform', 'Kindergarten', 'Male', '5XL', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(300, 'Blouse', 'School Uniform', 'Kindergarten', 'Female', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(301, 'Jumper', 'School Uniform', 'Kindergarten', 'Female', '6XL', 10, 470, 'Available', '0', '2025-10-07 12:46:08', NULL),
(302, 'Polo', 'School Uniform', 'Kindergarten', '', '6XL', 10, 450, 'Available', '0', '2025-10-07 12:46:08', NULL),
(352, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(353, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Small', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(354, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(355, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Large', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(356, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(357, 'Slacks', 'Corporate Attire', 'College', 'Male', '2XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(358, 'Slacks', 'Corporate Attire', 'College', 'Male', '3XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(359, 'Slacks', 'Corporate Attire', 'College', 'Male', '4XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(360, 'Slacks', 'Corporate Attire', 'College', 'Male', '5XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(361, 'Slacks', 'Corporate Attire', 'College', 'Male', '6XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(362, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(363, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Small', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(364, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(365, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Large', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(366, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(367, 'Blazer', 'Corporate Attire', 'College', 'Male', '2XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(368, 'Blazer', 'Corporate Attire', 'College', 'Male', '3XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(369, 'Blazer', 'Corporate Attire', 'College', 'Male', '4XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(370, 'Blazer', 'Corporate Attire', 'College', 'Male', '5XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(371, 'Blazer', 'Corporate Attire', 'College', 'Male', '6XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(372, 'Skirt', 'Corporate Attire', 'College', 'Male', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(373, 'Skirt', 'Corporate Attire', 'College', 'Male', 'Small', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(374, 'Skirt', 'Corporate Attire', 'College', 'Male', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(375, 'Skirt', 'Corporate Attire', 'College', 'Male', 'Large', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(376, 'Skirt', 'Corporate Attire', 'College', 'Male', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(377, 'Skirt', 'Corporate Attire', 'College', 'Male', '2XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(378, 'Skirt', 'Corporate Attire', 'College', 'Male', '3XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(379, 'Skirt', 'Corporate Attire', 'College', 'Male', '4XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(380, 'Skirt', 'Corporate Attire', 'College', 'Male', '5XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(381, 'Skirt', 'Corporate Attire', 'College', 'Male', '6XL', 10, 470, 'Available', 'Bachelor of Science in Information Technology', '2025-11-02 15:47:12', NULL),
(382, 'Slacks', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(383, 'Slacks', 'Corporate Attire', 'College', 'Female', 'Small', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(384, 'Slacks', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(385, 'Slacks', 'Corporate Attire', 'College', 'Female', 'Large', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(386, 'Slacks', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(387, 'Slacks', 'Corporate Attire', 'College', 'Female', '2XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(388, 'Slacks', 'Corporate Attire', 'College', 'Female', '3XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(389, 'Slacks', 'Corporate Attire', 'College', 'Female', '4XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(390, 'Slacks', 'Corporate Attire', 'College', 'Female', '5XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(391, 'Slacks', 'Corporate Attire', 'College', 'Female', '6XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(392, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(393, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Small', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(394, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(395, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Large', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(396, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(397, 'Blazer', 'Corporate Attire', 'College', 'Female', '2XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(398, 'Blazer', 'Corporate Attire', 'College', 'Female', '3XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(399, 'Blazer', 'Corporate Attire', 'College', 'Female', '4XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(400, 'Blazer', 'Corporate Attire', 'College', 'Female', '5XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(401, 'Blazer', 'Corporate Attire', 'College', 'Female', '6XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(402, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(403, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Small', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(404, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(405, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Large', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(406, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(407, 'Skirt', 'Corporate Attire', 'College', 'Female', '2XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(408, 'Skirt', 'Corporate Attire', 'College', 'Female', '3XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(409, 'Skirt', 'Corporate Attire', 'College', 'Female', '4XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(410, 'Skirt', 'Corporate Attire', 'College', 'Female', '5XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(411, 'Skirt', 'Corporate Attire', 'College', 'Female', '6XL', 10, 470, 'Available', 'Bachelor of Science in Computer Science', '2025-11-02 15:47:12', NULL),
(412, 'Blouse', 'Corporate Attire', 'College', 'Male', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(413, 'Blouse', 'Corporate Attire', 'College', 'Male', 'Small', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(414, 'Blouse', 'Corporate Attire', 'College', 'Male', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(415, 'Blouse', 'Corporate Attire', 'College', 'Male', 'Large', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(416, 'Blouse', 'Corporate Attire', 'College', 'Male', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(417, 'Blouse', 'Corporate Attire', 'College', 'Male', '2XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(418, 'Blouse', 'Corporate Attire', 'College', 'Male', '3XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(419, 'Blouse', 'Corporate Attire', 'College', 'Male', '4XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(420, 'Blouse', 'Corporate Attire', 'College', 'Male', '5XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(421, 'Blouse', 'Corporate Attire', 'College', 'Male', '6XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(422, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(423, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(424, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(425, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(426, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(427, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(428, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(429, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(430, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(431, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(432, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(433, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Small', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(434, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(435, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Large', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(436, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(437, 'Skirt', 'Corporate Attire', 'College', 'Female', '2XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(438, 'Skirt', 'Corporate Attire', 'College', 'Female', '3XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL);
INSERT INTO `tbluniforms` (`uniform_id`, `item_name`, `category`, `level`, `gender`, `size`, `stock_quantity`, `price`, `status`, `Course`, `date_added`, `date_updated`) VALUES
(439, 'Skirt', 'Corporate Attire', 'College', 'Female', '4XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(440, 'Skirt', 'Corporate Attire', 'College', 'Female', '5XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(441, 'Skirt', 'Corporate Attire', 'College', 'Female', '6XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(442, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(443, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Small', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(444, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(445, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Large', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(446, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(447, 'Blouse', 'Corporate Attire', 'College', 'Female', '2XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(448, 'Blouse', 'Corporate Attire', 'College', 'Female', '3XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(449, 'Blouse', 'Corporate Attire', 'College', 'Female', '4XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(450, 'Blouse', 'Corporate Attire', 'College', 'Female', '5XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(451, 'Blouse', 'Corporate Attire', 'College', 'Female', '6XL', 10, 470, 'Available', 'Bachelor of Science in Psychology', '2025-11-02 18:46:30', NULL),
(452, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 500, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(453, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 500, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(454, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 500, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(455, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 500, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(456, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 500, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(457, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 550, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(458, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 550, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(459, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 600, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(460, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 600, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(461, 'Cadet Top', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 600, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(462, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 480, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(463, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 480, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(464, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 480, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(465, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 480, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(466, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 480, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(467, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 530, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(468, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 530, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(469, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 580, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(470, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 580, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(471, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 580, 'Available', 'Bachelor of Science in Criminal Justice', '2025-11-02 22:38:11', NULL),
(472, 'Polo', 'Corporate Attire', 'College', 'Male', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(473, 'Polo', 'Corporate Attire', 'College', 'Male', 'Small', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(474, 'Polo', 'Corporate Attire', 'College', 'Male', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(475, 'Polo', 'Corporate Attire', 'College', 'Male', 'Large', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(476, 'Polo', 'Corporate Attire', 'College', 'Male', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(477, 'Polo', 'Corporate Attire', 'College', 'Male', '2XL', 10, 520, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(478, 'Polo', 'Corporate Attire', 'College', 'Male', '3XL', 10, 520, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(479, 'Polo', 'Corporate Attire', 'College', 'Male', '4XL', 10, 570, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(480, 'Polo', 'Corporate Attire', 'College', 'Male', '5XL', 10, 570, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(481, 'Polo', 'Corporate Attire', 'College', 'Male', '6XL', 10, 570, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(482, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(483, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Small', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(484, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(485, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Large', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(486, 'Blouse', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(487, 'Blouse', 'Corporate Attire', 'College', 'Female', '2XL', 10, 520, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(488, 'Blouse', 'Corporate Attire', 'College', 'Female', '3XL', 10, 520, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(489, 'Blouse', 'Corporate Attire', 'College', 'Female', '4XL', 10, 570, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(490, 'Blouse', 'Corporate Attire', 'College', 'Female', '5XL', 10, 570, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(491, 'Blouse', 'Corporate Attire', 'College', 'Female', '6XL', 10, 570, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(492, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(493, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(494, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(495, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(496, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(497, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 520, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(498, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 520, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(499, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 570, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(500, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 570, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(501, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 570, 'Available', 'Bachelor of Science in Education', '2025-11-02 23:07:32', NULL),
(502, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Extra Small', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(503, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Small', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(504, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Medium', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(505, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Large', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(506, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Extra Large', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(507, 'Blazer', 'Corporate Attire', 'College', 'Male', '2XL', 10, 900, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(508, 'Blazer', 'Corporate Attire', 'College', 'Male', '3XL', 10, 900, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(509, 'Blazer', 'Corporate Attire', 'College', 'Male', '4XL', 10, 950, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(510, 'Blazer', 'Corporate Attire', 'College', 'Male', '5XL', 10, 950, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(511, 'Blazer', 'Corporate Attire', 'College', 'Male', '6XL', 10, 950, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(512, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(513, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Small', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(514, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(515, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Large', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(516, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 850, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(517, 'Blazer', 'Corporate Attire', 'College', 'Female', '2XL', 10, 900, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(518, 'Blazer', 'Corporate Attire', 'College', 'Female', '3XL', 10, 900, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(519, 'Blazer', 'Corporate Attire', 'College', 'Female', '4XL', 10, 950, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(520, 'Blazer', 'Corporate Attire', 'College', 'Female', '5XL', 10, 950, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(521, 'Blazer', 'Corporate Attire', 'College', 'Female', '6XL', 10, 950, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(522, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Extra Small', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(523, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Small', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(524, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Medium', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(525, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Large', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(526, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Extra Large', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(527, 'Slacks', 'Corporate Attire', 'College', 'Male', '2XL', 10, 530, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(528, 'Slacks', 'Corporate Attire', 'College', 'Male', '3XL', 10, 530, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(529, 'Slacks', 'Corporate Attire', 'College', 'Male', '4XL', 10, 580, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(530, 'Slacks', 'Corporate Attire', 'College', 'Male', '5XL', 10, 580, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(531, 'Slacks', 'Corporate Attire', 'College', 'Male', '6XL', 10, 580, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(532, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(533, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Small', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(534, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(535, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Large', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(536, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 480, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(537, 'Skirt', 'Corporate Attire', 'College', 'Female', '2XL', 10, 530, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(538, 'Skirt', 'Corporate Attire', 'College', 'Female', '3XL', 10, 530, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(539, 'Skirt', 'Corporate Attire', 'College', 'Female', '4XL', 10, 580, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(540, 'Skirt', 'Corporate Attire', 'College', 'Female', '5XL', 10, 580, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(541, 'Skirt', 'Corporate Attire', 'College', 'Female', '6XL', 10, 580, 'Available', 'Bachelor of Science in Tourism Management', '2025-11-02 23:29:11', NULL),
(542, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 650, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(543, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 650, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(544, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 650, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(545, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 650, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(546, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 650, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(547, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 700, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(548, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 700, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(549, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 750, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(550, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 750, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(551, 'Chef Coat', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 750, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(552, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 550, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(553, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 550, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(554, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 550, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(555, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 550, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(556, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 550, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(557, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 600, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(558, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 600, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(559, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 650, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(560, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 650, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(561, 'Chef Trousers', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 650, 'Available', 'Bachelor of Science in Hospitality Management', '2025-11-02 23:55:52', NULL),
(562, 'Blazer', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 850, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(563, 'Blazer', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 850, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(564, 'Blazer', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 850, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(565, 'Blazer', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 850, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(566, 'Blazer', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 850, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(567, 'Blazer', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 900, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(568, 'Blazer', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 900, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(569, 'Blazer', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 950, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(570, 'Blazer', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 950, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(571, 'Blazer', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 950, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(572, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 480, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(573, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 480, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(574, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 480, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(575, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 480, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(576, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 480, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(577, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 530, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(578, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 530, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(579, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 580, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(580, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 580, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(581, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 580, 'Available', 'Bachelor of Science in Engineering', '2025-11-03 00:13:06', NULL),
(582, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Extra Small', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(583, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Small', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(584, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Medium', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(585, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Large', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(586, 'Blazer', 'Corporate Attire', 'College', 'Male', 'Extra Large', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(587, 'Blazer', 'Corporate Attire', 'College', 'Male', '2XL', 10, 900, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(588, 'Blazer', 'Corporate Attire', 'College', 'Male', '3XL', 10, 900, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(589, 'Blazer', 'Corporate Attire', 'College', 'Male', '4XL', 10, 950, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(590, 'Blazer', 'Corporate Attire', 'College', 'Male', '5XL', 10, 950, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(591, 'Blazer', 'Corporate Attire', 'College', 'Male', '6XL', 10, 950, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(592, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(593, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Small', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(594, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(595, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Large', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(596, 'Blazer', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 850, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(597, 'Blazer', 'Corporate Attire', 'College', 'Female', '2XL', 10, 900, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(598, 'Blazer', 'Corporate Attire', 'College', 'Female', '3XL', 10, 900, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(599, 'Blazer', 'Corporate Attire', 'College', 'Female', '4XL', 10, 950, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(600, 'Blazer', 'Corporate Attire', 'College', 'Female', '5XL', 10, 950, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(601, 'Blazer', 'Corporate Attire', 'College', 'Female', '6XL', 10, 950, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(602, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Extra Small', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(603, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Small', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(604, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Medium', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(605, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Large', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(606, 'Slacks', 'Corporate Attire', 'College', 'Male', 'Extra Large', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(607, 'Slacks', 'Corporate Attire', 'College', 'Male', '2XL', 10, 530, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(608, 'Slacks', 'Corporate Attire', 'College', 'Male', '3XL', 10, 530, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(609, 'Slacks', 'Corporate Attire', 'College', 'Male', '4XL', 10, 580, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(610, 'Slacks', 'Corporate Attire', 'College', 'Male', '5XL', 10, 580, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(611, 'Slacks', 'Corporate Attire', 'College', 'Male', '6XL', 10, 580, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(612, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Extra Small', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(613, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Small', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(614, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Medium', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(615, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Large', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(616, 'Skirt', 'Corporate Attire', 'College', 'Female', 'Extra Large', 10, 480, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(617, 'Skirt', 'Corporate Attire', 'College', 'Female', '2XL', 10, 530, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(618, 'Skirt', 'Corporate Attire', 'College', 'Female', '3XL', 10, 530, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(619, 'Skirt', 'Corporate Attire', 'College', 'Female', '4XL', 10, 580, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(620, 'Skirt', 'Corporate Attire', 'College', 'Female', '5XL', 10, 580, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(621, 'Skirt', 'Corporate Attire', 'College', 'Female', '6XL', 10, 580, 'Available', 'Bachelor of Business Administration', '2025-11-03 00:26:59', NULL),
(622, 'Vest', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 550, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(623, 'Vest', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 550, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(624, 'Vest', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 550, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(625, 'Vest', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 550, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(626, 'Vest', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 550, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(627, 'Vest', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 600, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(628, 'Vest', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 600, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(629, 'Vest', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 650, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(630, 'Vest', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 650, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(631, 'Vest', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 650, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(632, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 480, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(633, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 480, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(634, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 480, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(635, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 480, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(636, 'Slacks', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 480, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(637, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 530, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(638, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 530, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(639, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 580, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(640, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 580, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(641, 'Slacks', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 580, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(642, 'Polo', 'Corporate Attire', 'College', 'Unisex', 'Extra Small', 10, 470, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(643, 'Polo', 'Corporate Attire', 'College', 'Unisex', 'Small', 10, 470, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(644, 'Polo', 'Corporate Attire', 'College', 'Unisex', 'Medium', 10, 470, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(645, 'Polo', 'Corporate Attire', 'College', 'Unisex', 'Large', 10, 470, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(646, 'Polo', 'Corporate Attire', 'College', 'Unisex', 'Extra Large', 10, 470, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(647, 'Polo', 'Corporate Attire', 'College', 'Unisex', '2XL', 10, 520, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(648, 'Polo', 'Corporate Attire', 'College', 'Unisex', '3XL', 10, 520, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(649, 'Polo', 'Corporate Attire', 'College', 'Unisex', '4XL', 10, 570, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(650, 'Polo', 'Corporate Attire', 'College', 'Unisex', '5XL', 10, 570, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL),
(651, 'Polo', 'Corporate Attire', 'College', 'Unisex', '6XL', 10, 570, 'Available', 'Bachelor of Science in Accountancy', '2025-11-03 00:51:55', NULL);

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
('187823', 'Saguban', 'Bianca Jeanelle', 'Tuazon', 'SAGUBAN', 'Student', 'biancaa@gmail.com', 'Active', 3),
('188123', 'Obis', 'Francine Mei', 'Ramirez', 'OBIS', 'Student', 'francine@gmail.com', 'Active', 3),
('200823', 'Cenardo', 'Vernalyn', 'Equing', 'CENARDO', 'Student', 'vernalyn@gmail.com', 'Active', 3),
('209723', 'Matiga', 'Xyrylle Claire', 'Lasin', 'MATIGA', 'Student', 'xyryllematiga@gmail.com', 'Active', 3);

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
  ADD PRIMARY KEY (`uniform_id`);

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
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `tbluniforms`
--
ALTER TABLE `tbluniforms`
  MODIFY `uniform_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=655;

--
-- AUTO_INCREMENT for table `tbl_pullouts`
--
ALTER TABLE `tbl_pullouts`
  MODIFY `PulloutId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbluniformlogs`
--
ALTER TABLE `tbluniformlogs`
  ADD CONSTRAINT `tbluniformlogs_ibfk_1` FOREIGN KEY (`admin_id`) REFERENCES `tbladmin_users` (`admin_id`);

--
-- Constraints for table `tbl_pullouts`
--
ALTER TABLE `tbl_pullouts`
  ADD CONSTRAINT `tbl_pullouts_ibfk_1` FOREIGN KEY (`uniform_id`) REFERENCES `tbluniforms` (`uniform_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

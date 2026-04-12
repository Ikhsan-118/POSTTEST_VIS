-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 12 Apr 2026 pada 17.46
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbspotify`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbalbum`
--

CREATE TABLE `tbalbum` (
  `kodeAlbum` varchar(10) NOT NULL,
  `judulAlbum` varchar(100) NOT NULL,
  `artis` varchar(100) NOT NULL,
  `tahunRilis` int(11) NOT NULL,
  `genre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbalbum`
--

INSERT INTO `tbalbum` (`kodeAlbum`, `judulAlbum`, `artis`, `tahunRilis`, `genre`) VALUES
('hindia1', 'Menari Dengan Bayangan', 'Hindia', 2019, 'Indie'),
('kunto1', 'Mantra Mantra', 'Kunto Aji', 2018, 'Pop/Indie'),
('tulus1', 'Monokrom', 'Tulus', 2016, 'Pop'),
('fourt1', 'Lelaku', 'Fourtwnty', 2015, 'Indie Folk'),
('feast1', 'Membangun dan Menghancurkan', '.Feast', 2024, 'Rock'),
('fiersa1', 'Tempat Aku Pulang', 'Fiersa Besari', 2014, 'Indie Pop'),
('nadin1', 'Selamat Ulang Tahun', 'Nadin Amizah', 2020, 'Folk'),
('pama1', 'Walk the Talk', 'Pamungkas', 2018, 'Indie Pop'),
('baskara1', 'Lomba Sihir', 'Lomba Sihir', 2021, 'Indie'),
('reality1', 'Never Get Better', 'Reality Club', 2017, 'Indie Rock'),
('isya1', 'Lexicon', 'Isyana Sarasvati', 2019, 'Progressive Rock'),
('barasu1', 'Taifun', 'Barasuara', 2015, 'Indie Rock'),
('coldp1', 'Parachutes', 'Coldplay', 2000, 'Alternative Rock'),
('arctic1', 'AM', 'Arctic Monkeys', 2013, 'Indie Rock'),
('mocca1', 'Friends', 'Mocca', 2004, 'Indie Pop/Jazz'),
('payun1', 'Dunia Batas', 'Payung Teduh', 2012, 'Indie Folk'),
('float1', 'Music for 3 Hari Untuk Selamanya', 'Float', 2007, 'Indie/Folk'),
('dewa1', 'Bintang Lima', 'Dewa 19', 2000, 'Pop Rock'),
('peter1', 'Bintang di Surga', 'Peterpan', 2004, 'Pop Rock'),
('sheila1', 'Kisah Klasik Untuk Masa Depan', 'Sheila on 7', 2000, 'Pop');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbalbum`
--
ALTER TABLE `tbalbum`
  ADD PRIMARY KEY (`kodeAlbum`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

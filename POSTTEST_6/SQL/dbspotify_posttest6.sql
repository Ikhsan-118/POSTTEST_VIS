-- ============================================================
-- dbspotify - POSTTEST 6
-- Database dengan relasi tbalbum (induk) -> tblagu (anak)
-- ============================================================

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";

/*!40101 SET NAMES utf8mb4 */;

-- --------------------------------------------------------
-- Database: `dbspotify`
-- --------------------------------------------------------
CREATE DATABASE IF NOT EXISTS `dbspotify`
  DEFAULT CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;

USE `dbspotify`;

-- --------------------------------------------------------
-- Tabel induk: tbalbum
-- --------------------------------------------------------
DROP TABLE IF EXISTS `tblagu`;
DROP TABLE IF EXISTS `tbalbum`;

CREATE TABLE `tbalbum` (
  `kodeAlbum`   VARCHAR(10)  NOT NULL,
  `judulAlbum`  VARCHAR(100) NOT NULL,
  `artis`       VARCHAR(100) NOT NULL,
  `tahunRilis`  INT(11)      NOT NULL,
  `genre`       VARCHAR(50)  NOT NULL,
  PRIMARY KEY (`kodeAlbum`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------
-- Tabel anak: tblagu  (Foreign Key -> tbalbum.kodeAlbum)
-- --------------------------------------------------------
CREATE TABLE `tblagu` (
  `kodeLagu`    VARCHAR(15)  NOT NULL,
  `kodeAlbum`  VARCHAR(10)  NOT NULL,
  `judulLagu`  VARCHAR(100) NOT NULL,
  `durasi`     INT(11)      NOT NULL COMMENT 'Durasi dalam detik',
  `trackNo`    INT(11)      NOT NULL DEFAULT 1,
  PRIMARY KEY (`kodeLagu`),
  CONSTRAINT `fk_lagu_album`
    FOREIGN KEY (`kodeAlbum`)
    REFERENCES `tbalbum` (`kodeAlbum`)
    ON DELETE CASCADE
    ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------
-- Data untuk tbalbum
-- --------------------------------------------------------
INSERT INTO `tbalbum` VALUES
('hindia1',  'Menari Dengan Bayangan',       'Hindia',          2019, 'Indie'),
('kunto1',   'Mantra Mantra',                'Kunto Aji',       2018, 'Pop/Indie'),
('tulus1',   'Monokrom',                     'Tulus',           2016, 'Pop'),
('fourt1',   'Lelaku',                       'Fourtwnty',       2015, 'Indie Folk'),
('feast1',   'Membangun dan Menghancurkan',  '.Feast',          2024, 'Rock'),
('fiersa1',  'Tempat Aku Pulang',            'Fiersa Besari',   2014, 'Indie Pop'),
('nadin1',   'Selamat Ulang Tahun',          'Nadin Amizah',    2020, 'Folk'),
('pama1',    'Walk the Talk',                'Pamungkas',       2018, 'Indie Pop'),
('baskara1', 'Lomba Sihir',                  'Lomba Sihir',     2021, 'Indie'),
('reality1', 'Never Get Better',             'Reality Club',    2017, 'Indie Rock'),
('coldp1',   'Parachutes',                   'Coldplay',        2000, 'Alternative Rock'),
('arctic1',  'AM',                           'Arctic Monkeys',  2013, 'Indie Rock'),
('mocca1',   'Friends',                      'Mocca',           2004, 'Indie Pop/Jazz'),
('payun1',   'Dunia Batas',                  'Payung Teduh',    2012, 'Indie Folk'),
('dewa1',    'Bintang Lima',                 'Dewa 19',         2000, 'Pop Rock'),
('sheila1',  'Kisah Klasik Untuk Masa Depan','Sheila on 7',     2000, 'Pop');

-- --------------------------------------------------------
-- Data untuk tblagu
-- --------------------------------------------------------
INSERT INTO `tblagu` VALUES
('lagu001', 'hindia1',  'Secukupnya',         215, 1),
('lagu002', 'hindia1',  'Evaluasi',           241, 2),
('lagu003', 'hindia1',  'Belum Tidur',        198, 3),
('lagu004', 'kunto1',   'Rehat',              258, 1),
('lagu005', 'kunto1',   'Topik Semalam',      233, 2),
('lagu006', 'kunto1',   'Terlalu Lama Sendiri', 245, 3),
('lagu007', 'tulus1',   'Monokrom',           240, 1),
('lagu008', 'tulus1',   'Ruang Sendiri',      212, 2),
('lagu009', 'coldp1',   'Yellow',             270, 5),
('lagu010', 'coldp1',   'The Scientist',      309, 7),
('lagu011', 'arctic1',  'Do I Wanna Know?',   272, 1),
('lagu012', 'arctic1',  'R U Mine?',          202, 2),
('lagu013', 'arctic1',  'Why''d You Only Call Me When You''re High?', 164, 10),
('lagu014', 'nadin1',   'Rumpang',            228, 1),
('lagu015', 'nadin1',   'Cinta Melulu',       184, 4),
('lagu016', 'dewa1',    'Roman Picisan',      255, 1),
('lagu017', 'dewa1',    'Cinta 'Tlah Pergi',  262, 3),
('lagu018', 'sheila1',  'Bila Kau Tak Disini',278, 1),
('lagu019', 'sheila1',  'Melompat Lebih Tinggi', 195, 4);

COMMIT;

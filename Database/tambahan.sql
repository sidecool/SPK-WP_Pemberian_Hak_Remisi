CREATE TABLE `t_normalisasi_bobot` (
`kd_kriteria` varchar(25),
`n_bobot` decimal(10,4)
);

ALTER TABLE `t_normalisasi_bobot`
ADD PRIMARY KEY (`KD_KRITERIA`);

ALTER TABLE `t_nilai_vektor`
ALTER `n_vektor_s` SET DEFAULT 0,
ALTER `n_preferensi` SET DEFAULT 0;
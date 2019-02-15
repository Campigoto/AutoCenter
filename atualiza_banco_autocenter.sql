use AutoCenter;

select * from carro WHERE CAR_PLACA = 'MGX-5459';


alter table carro add car_km_cada_troca_oleo bigint;
alter table carro add car_km_ultima_troca_oleo bigint;
alter table ordem_servico add os_km_atual bigint; 
alter table carro add car_km_cada_troca_correia bigint;
alter table carro add car_km_ultima_troca_correia bigint;
alter table detalhe_os add observacao text;

select * from DETALHE_OS where observacao is not null;


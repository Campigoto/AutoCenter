select * from carro WHERE CAR_PLACA = 'MGX-5459';


alter table carro add car_km_cada_troca bigint;
alter table carro add car_km_ultima_troca bigint;
alter table ordem_servico add os_km_atual bigint;

select top 1 * from ORDEM_SERVICO;


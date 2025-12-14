
insert into RubrosEmprendimiento values
('Tecnologia', 'Tecnologia'),
('Gastronomia', 'Gastronomia')

insert into Facultades values
('Ciencias matematicas y fisicas', 'Ciencias matematicas y fisicas'),
('Medicina', 'Medicina')

insert into Eventos values
('Innova', 'Evento de tecnologia', '01/08/2025', '01/09/2025', 'Centro de convenciones')

insert into CargosParticipante values
('Administrador', 'Administrador'),
('Visitante', 'Visitante'),
('Supervisor', 'Supervisor'),
('Participante general', 'Participante general')


insert into RolUsuarios values
('Administrador', 'ADM'),
('Estudiante', 'Est')

insert into Usuarios values
('admin', 'admin', 1),
('estu', 'estu', 2)

insert into MenuOpciones values
('Rubro de emprendimientos', 'RBR', 'MAESTRO_GENERAL_ADM', 1),
('Facultades', 'FCL', 'MAESTRO_GENERAL_ADM', 1)

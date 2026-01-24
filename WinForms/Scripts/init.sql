create procedure dbo.SpConsultarParticipantes
as
begin
	select p.Id, p.Nombres, p.Apellidos, p.NumeroTelefono, p.NumeroIdentificacion, cp.Nombre
	from Participantes p 
	inner join CargosParticipante cp on p.IdCargoParticipante = cp.id
end

insert into RubrosEmprendimiento values
('Tecnologia', 'Tecnologia'),
('Gastronomia', 'Gastronomia')

insert into Facultades values
('Ciencias matematicas y fisicas', 'Ciencias matematicas y fisicas'),
('Medicina', 'Medicina')

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

insert into Configs values
(0, GETDATE(), null)


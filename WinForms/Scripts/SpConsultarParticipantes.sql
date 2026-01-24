create procedure dbo.SpConsultarParticipantes
as
begin
	select p.Id, p.Nombres, p.Apellidos, p.NumeroTelefono, p.NumeroIdentificacion, cp.Nombre
	from Participantes p 
	inner join CargosParticipante cp on p.IdCargoParticipante = cp.id
end
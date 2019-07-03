create table Tpo_box(
	date_reception varchar(50) not null,
	direction varchar(50),
	emetteur varchar(50),
	destinataire varchar(50),
	fournisseur varchar(50) not null,
	date_facture varchar(50) not null,
	montant_ttc float not null,
	devise varchar(10) not null,
	objet_facture varchar(50),
	Nfacture varchar(50) not null,
	Ncommande varchar(50)not null,
	date_envoi_fedaso varchar(50),
	restitution_fedosa varchar(10) ,
	envoie_dfi varchar(10) ,
	remarque varchar(50) ,
	pole varchar(50) ,
	date_envoi_dfi varchar(50)
)
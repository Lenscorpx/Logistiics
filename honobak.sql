
/****** Object:  Table t_client    Script Date: 14/09/2017 03:36:50 ******/
use master
go
if exists(select * from sys.databases where name='kb_tech_datas')
drop database kb_tech_datas
go
create database kb_tech_datas
go
use kb_tech_datas
go
create table t_agent
(
	matricule_agent nvarchar(50),
	noms_agent nvarchar(50),
	adresse nvarchar(100),
	telephone nvarchar(50),
	fonction nvarchar(50),
	date_naissance date,
	constraint pk_agent primary key(matricule_agent)
	)
go
create table t_client
	(
	matricule_client nvarchar(50),
	noms_client nvarchar(50),
	adresse nvarchar(100),
	telephone nvarchar(50),
	fonction nvarchar(50),
	constraint pk_primary primary key(matricule_client)
	)
go
/****** Object:  Table t_equipement  ******/
create table t_equipement
	(
	code_equipement nvarchar(50),
	designation_equipement nvarchar(50),
 constraint pk_equipement primary key(code_equipement)
)
go
/****** Object:  Table t_depot     ******/

create table t_depot
	(
	code_depot nvarchar(50),
	designation_depot nvarchar(50),
 constraint pk_depot primary key (code_depot)
 ) 
go
/****** Object:  Table t_fournisseur     ******/

create table t_fournisseur
	(
	code_fournisseur nvarchar(50),
	noms_fournisseur nvarchar(50),
	adresse_fournisseur nvarchar(50),
	telephone_fournisseur nvarchar(50),
	mail_fournisseur nvarchar(50),
 constraint pk_fournisseur primary key (code_fournisseur)
 )
go
/****** Object:  Table t_approvisionnement  ******/
create table t_approvisionnement
	(
	code_approvisionnement nvarchar(50),
	date_approvisionnement date,
	code_equipement nvarchar(50),
	code_fournisseur nvarchar(50),
	code_depot nvarchar(50),
	quantite int,
	cout_total decimal(18,0),
	
 constraint pk_approvisionnement primary key(code_approvisionnement),
 constraint fk_equipement_approv foreign key(code_equipement) references t_equipement(code_equipement),
 constraint fk_fournisseur_approv foreign key(code_fournisseur) references t_fournisseur(code_fournisseur),
 constraint fk_depot_approv foreign key(code_depot) references t_depot(code_depot)
)
go
/****** Object:  Table t_demande     ******/

create table t_demande
	(
	code_demande nvarchar(50),
	concerne_demande nvarchar(50),
	date_demande date,
 constraint pk_demande primary key (code_demande)
)
go
/****** Object:  Table t_attribution_facture    ******/

create table t_facture
	(
	code_facture int identity,
	date_facture date,
	matricule_client nvarchar(50),
 constraint pk_attribution primary key (code_facture),
 constraint fk_client_facture foreign key(matricule_client) references t_client(matricule_client)
)
go
/****** Object:  Table t_attribution_equipement     ******/
create table t_details_facture
	(
	num_details int identity,
	code_facture int,
	code_approvisionnement nvarchar(50),
	qte_vendue int,
	prix_unitaire decimal,
	prix_total decimal,
	constraint pk_details_facture primary key(num_details),
	constraint fk_code_facture foreign key(code_facture) references t_facture(code_facture),
	constraint fk_approvisionnement_details foreign key(code_approvisionnement) references t_approvisionnement(code_approvisionnement)
		)
	go
create table t_paiement_facture
	(
		num_paiement int identity,
		date_paiement date,
		code_facture int,
		montant_paye decimal,
		libelle_paiement nvarchar(100),
		constraint pk_paiement_facture primary key(num_paiement),
		constraint fk_facture_paiement foreign key(code_facture) references t_facture(code_facture)
		)
	go
/****** Object:  Table t_login     ******/

create table t_login(
	nom_utilisateur nvarchar(50),
	mot_de_passe nvarchar(50),
	niveau_acces nvarchar(50),
 constraint pk_login primary key(nom_utilisateur)
 )
go
/****** Object:  StoredProcedure afficher_client     ******/

create procedure afficher_client
as
select top 500 matricule_client, 
			   noms_client,
			   adresse,
			   telephone,
			   fonction
			   from t_client
			order by noms_client desc


go
create procedure afficher_agent
as
select top 500 matricule_agent, 
			   noms_agent,
			   adresse,
			   telephone,
			   fonction,
			   date_naissance
			   from t_agent
			order by noms_agent desc
GO
/****** Object:  StoredProcedure afficher_approvisionnement     ******/

create procedure afficher_approvisionnement
as
select top 500 code_approvisionnement as 'Code', date_approvisionnement as 'Date', code_equipement as 'Equipement', code_fournisseur as 'Fournisseur', code_depot as 'Depot', quantite as 'Qte', cout_total as 'Prix'
	from t_approvisionnement
		order by date_approvisionnement desc, code_approvisionnement desc

go
/****** Object:  StoredProcedure afficher_demande     ******/

create procedure afficher_demande
		as
			select top 500 
				code_demande,
				concerne_demande,
				date_demande
					from t_demande
						order by date_demande desc,
								 code_demande desc


go
/****** Object:  StoredProcedure afficher_depot     ******/

create procedure afficher_depot
	as
		select top 500 code_depot,designation_depot
			from t_depot
				order by code_depot asc

go
/****** Object:  StoredProcedure afficher_equipement     ******/

create procedure afficher_equipement
as
	select top 500 code_equipement, designation_equipement
		from t_equipement
		order by code_equipement asc


go
/****** Object:  StoredProcedure afficher_fournisseur     ******/

create procedure afficher_fournisseur
	as
		select top 500 code_fournisseur, 
					   noms_fournisseur, 
					   adresse_fournisseur, 
					   telephone_fournisseur, 
					   mail_fournisseur
		from t_fournisseur
				order by noms_fournisseur asc

go
/****** Object:  StoredProcedure charger_approvisionnement     ******/

create procedure charger_approvisionnement
as
	select 
	code_approvisionnement
	from t_approvisionnement
	order by code_approvisionnement desc


go
/****** Object:  StoredProcedure charger_demande     ******/

create procedure charger_demande
as
select code_demande from t_demande
order by code_demande desc


go
/****** Object:  StoredProcedure charger_depot     ******/

create procedure charger_depot
as
select 
	code_depot from t_depot
	order by code_depot asc


go
/****** Object:  StoredProcedure charger_equipement     ******/

create procedure charger_equipement
as
	select 
	code_equipement from t_equipement
	order by code_equipement asc


go
/****** Object:  StoredProcedure charger_fournisseur     ******/

create procedure charger_fournisseur
as
select
	code_fournisseur 
	from t_fournisseur
	order by code_fournisseur asc


go
/****** Object:  StoredProcedure charger_matricule     ******/

create procedure charger_matricule
as
	select matricule_client from t_client
	order by matricule_client asc


go
/****** Object:  StoredProcedure enregistrer_client     ******/

create procedure enregistrer_client
	@matricule_client nvarchar(50),
	@noms_client nvarchar(50),
	@adresse nvarchar(100),
	@telephone nvarchar(50),
	@fonction nvarchar(50)
	as
		merge t_client as table_client
		using(select @matricule_client,@noms_client,@adresse,@telephone,@fonction)
			as table_source_client(source_matricule,source_noms,source_adresse,source_telephone,source_fonction)
			on(table_client.matricule_client=table_source_client.source_matricule)
			when matched then
				update set noms_client=source_noms,
						   adresse=source_adresse,
						   telephone=source_telephone,
						   fonction=source_fonction
			when not matched then
				insert (matricule_client,noms_client,adresse,telephone,fonction)
				values (source_matricule,source_noms,source_adresse,source_telephone,source_fonction);

go
/****** Object:  StoredProcedure enregistrer_demande     ******/

create procedure enregistrer_demande
	@code_demande nvarchar(50),
	@concerne_demande nvarchar(50),
	@date_demande date
	as
		merge t_demande
		using (select @code_demande, @concerne_demande, @date_demande) as
			t_demande_source(source_code_demande, source_concerne_demande, source_date_demande)
		on(code_demande=source_code_demande)
		when matched then
			update set
				code_demande=source_code_demande,
				concerne_demande=source_concerne_demande,
				date_demande=source_date_demande
		when not matched then
			insert (code_demande, concerne_demande, date_demande)
			values (source_code_demande, source_concerne_demande, source_date_demande);


go
/****** Object:  StoredProcedure enregistrer_depot     ******/

create procedure enregistrer_depot
	@code_depot nvarchar(50),
	@designation_depot nvarchar(50)
	as
		merge t_depot as t_depot
		using (select @code_depot, @designation_depot)
			as t_depot_values(v_code_depot, v_designation_depot)
		on (code_depot=v_code_depot)
		when matched then
			update set
				designation_depot=v_code_depot
		when not matched then
			insert (code_depot,designation_depot)
			values(v_code_depot, v_designation_depot);


go
/****** Object:  StoredProcedure enregistrer_equipement     ******/

create procedure enregistrer_equipement
	@code_equipement nvarchar(50),
	@designation_equipement nvarchar(50)
	as
	merge t_equipement
		using (select @code_equipement, @designation_equipement)
			as t_equipement_values(v_code_equipement, v_designation_equipement)
		on (code_equipement=v_code_equipement)
		when matched then
			update set
				designation_equipement=v_code_equipement
		when not matched then
			insert (code_equipement, designation_equipement)
			values(v_code_equipement, v_designation_equipement);


go
/****** Object:  StoredProcedure enregistrer_fournisseur     ******/

---------------------------------------------------------- Fin Equipement ---------------------------
---------------------------------------------------------- Debut Fournisseur -------------------------
create procedure enregistrer_fournisseur
	@code_fournisseur nvarchar(50),
	@noms_fournisseur nvarchar(50),
	@adresse_fournisseur nvarchar(50),
	@telephone_fournisseur nvarchar(50),
	@mail_fournisseur nvarchar(50)
	as
		merge t_fournisseur
			using (select @code_fournisseur, 
						  @noms_fournisseur, 
						  @adresse_fournisseur,
						  @telephone_fournisseur,
						  @mail_fournisseur)
						  as
					t_source_fournisseur
					(
						  code_fournisseur_source,
						  noms_fournisseur_source, 
						  adresse_fournisseur_source,
						  telephone_fournisseur_source,
						  mail_fournisseur_source)
				on(code_fournisseur=code_fournisseur_source)
				when matched then
				update set
					noms_fournisseur=@noms_fournisseur,
					adresse_fournisseur=@adresse_fournisseur,
					telephone_fournisseur=@telephone_fournisseur,
					mail_fournisseur=@mail_fournisseur
				when not matched then
					insert (code_fournisseur,
							noms_fournisseur,
							adresse_fournisseur,
							telephone_fournisseur,
							mail_fournisseur)
					values (@code_fournisseur,
							@noms_fournisseur,
							@adresse_fournisseur,
							@telephone_fournisseur,
							@mail_fournisseur);


go
/****** Object:  StoredProcedure enregistrer_login     ******/

create procedure enregistrer_login
	@nom_utilisateur nvarchar(50),
	@mot_de_passe nvarchar(50),
	@niveau_acces nvarchar(50)
	as
	merge t_login as t_logins
	using(select @nom_utilisateur, @mot_de_passe, @niveau_acces) 
		as t_parametres(prm_nom_utilisateur, prm_mot_de_passe, prm_niveau_acces)
	on(t_logins.nom_utilisateur=t_parametres.prm_nom_utilisateur)
		when matched then
			update set mot_de_passe=t_parametres.prm_mot_de_passe,
					   niveau_acces=t_parametres.prm_niveau_acces
		when not matched then
			insert (nom_utilisateur, mot_de_passe, niveau_acces)
			values(@nom_utilisateur, @mot_de_passe, @niveau_acces);


go
/****** Object:  StoredProcedure inserer_approvisionnement     ******/

create procedure inserer_approvisionnement
	@code_approvisionnement nvarchar(50),
	@date_approvisionnement date,
	@code_equipement nvarchar(50),
	@code_fournisseur nvarchar(50),
	@code_depot nvarchar(50),
	@quantite int,
	@cout_total decimal
	as
		merge t_approvisionnement
		using (select @code_approvisionnement, @date_approvisionnement, @code_equipement, @code_fournisseur, @code_depot, @quantite, @cout_total) 
			as xapprovisionnement(xcode_approvisionnement, xdate_approvisionnement, xcode_equipement, xcode_fournisseur, xcode_depot, xquantite, xcout_total)
		on(t_approvisionnement.code_approvisionnement=xapprovisionnement.xcode_approvisionnement)
		when matched then
			update set
				date_approvisionnement=@date_approvisionnement,
				code_equipement=@code_equipement,
				code_fournisseur=@code_fournisseur,
				code_depot=@code_depot,
				quantite=@quantite,
				cout_total=@cout_total
		when not matched then
			insert (code_approvisionnement, date_approvisionnement, code_equipement, code_fournisseur, code_depot, quantite, cout_total)
			values (@code_approvisionnement, @date_approvisionnement, @code_equipement, @code_fournisseur, @code_depot, @quantite, @cout_total);


go
/****** Object:  StoredProcedure liste_equipement_recus_entre_dates     ******/

create procedure liste_equipement_recus_entre_dates
@date_un date,
@date_deux date
as
SELECT        t_equipement.code_equipement, t_equipement.designation_equipement, t_approvisionnement.date_approvisionnement, t_approvisionnement.quantite, t_approvisionnement.cout_total, 
                         t_approvisionnement.code_depot, t_approvisionnement.code_fournisseur
FROM            t_equipement inner join
                         t_approvisionnement on t_equipement.code_equipement = t_approvisionnement.code_equipement inner join
                         t_fournisseur on t_approvisionnement.code_fournisseur = t_fournisseur.code_fournisseur inner join
                         t_depot on t_approvisionnement.code_depot = t_depot.code_depot
			where t_approvisionnement.date_approvisionnement between @date_un and @date_deux


go
create procedure recherche_client_par_matricule
	@matricule_client nvarchar(50)
	as
		select * from t_client 
			where matricule_client like '%'+@matricule_client+'%'


go
/****** Object:  StoredProcedure recherche_client_par_nom     ******/

create procedure recherche_client_par_nom
	@noms_client nvarchar(50)
	as
		select * from t_client 
			where noms_client like '%'+@noms_client+'%'


go
/****** Object:  StoredProcedure rechercher_approvisionnement_entre_date     ******/

create procedure rechercher_approvisionnement_entre_date
	@date_un date,
	@date_deux date
	as
	select * from t_approvisionnement
		where date_approvisionnement between @date_un and @date_deux
			order by code_approvisionnement desc


go
/****** Object:  StoredProcedure rechercher_approvisionnement_par_equipement     ******/

create procedure rechercher_approvisionnement_par_equipement
	@code_equipement nvarchar(50)
	as
	select top 500 code_approvisionnement, date_approvisionnement, code_equipement, code_fournisseur, code_depot, quantite, cout_total
		from t_approvisionnement
			where code_equipement=@code_equipement
				order by date_approvisionnement desc


go
/****** Object:  StoredProcedure rechercher_demande_date     ******/

create procedure rechercher_demande_date
	@date_demande date
		as
			select top 500
				code_demande,
				concerne_demande,
				date_demande
					from t_demande
						where date_demande like @date_demande
							order by code_demande desc


go
/****** Object:  StoredProcedure rechercher_depot     ******/

create procedure rechercher_depot
	@code_depot nvarchar(50)
	as
	select * from t_depot
		where code_depot=@code_depot


go
/****** Object:  StoredProcedure rechercher_equipement     ******/

create procedure rechercher_equipement
	@code_equipement nvarchar(50)
	as
		select * from t_equipement
			where code_equipement like '%'+@code_equipement+'%' 
				order by designation_equipement asc


go

create procedure rechercher_fournisseur
	@code_fournisseur nvarchar(50)
	as
		select top 500 code_fournisseur, 
					   noms_fournisseur, 
					   adresse_fournisseur, 
					   telephone_fournisseur, 
					   mail_fournisseur
		from t_fournisseur
			where code_fournisseur=@code_fournisseur
				order by noms_fournisseur asc


go
/****** Object:  StoredProcedure rechercher_login     ******/

create procedure rechercher_login
	@nom_utilisateur nvarchar(50),
	@mot_de_passe nvarchar(50)
	as
	select niveau_acces from t_login 
		where nom_utilisateur 
			like @nom_utilisateur and mot_de_passe=@mot_de_passe


go
/****** Object:  StoredProcedure recuperer_nom_equipement     ******/

create procedure recuperer_nom_equipement
@code_approvisionnement nvarchar(50)
as
	select code_equipement from t_approvisionnement
	where code_approvisionnement=@code_approvisionnement


go
/****** Object:  StoredProcedure select_equipement     ******/

create procedure select_equipement
@code_approvisionnement nvarchar(50)
as
	select code_equipement from t_approvisionnement
	where code_approvisionnement=@code_approvisionnement


go
/****** Object:  StoredProcedure somme_entrees     ******/

create procedure somme_entrees
@code_equipement nvarchar(50)
as
	select sum (quantite) as total_entree
		from t_approvisionnement
	where code_equipement = @code_equipement


go
/****** Object:  StoredProcedure somme_sorties     ******/

--@code_approvisionnement nvarchar(50)
--as
--	select sum(qte_attribue) as total_sortie
--		from t_attribution_equipement
--	where code_approvisionnement=@code_approvisionnement


--go
/****** Object:  StoredProcedure supprimer_client     ******/

create procedure supprimer_client
	@matricule_client nvarchar(50)
	as
		delete from t_client
			where matricule_client=@matricule_client


go
/****** Object:  StoredProcedure supprimer_approvisionnement     ******/

create procedure supprimer_approvisionnement
	@code_approvisionnement nvarchar(50)
	as
	delete from t_approvisionnement
		where code_approvisionnement=@code_approvisionnement


go
/****** Object:  StoredProcedure supprimer_demande     ******/

create procedure supprimer_demande
	@code_demande nvarchar(50)
	as
		delete from	
			t_demande
				where code_demande like @code_demande


go
/****** Object:  StoredProcedure supprimer_depot     ******/

create procedure supprimer_depot
	@code_depot nvarchar(50)
	as
	delete from t_depot
		where code_depot=@code_depot


go
/****** Object:  StoredProcedure supprimer_equipement     ******/

create procedure supprimer_equipement
	@code_equipement nvarchar(50)
	as
		delete from t_equipement
			where code_equipement like @code_equipement


go
/****** Object:  StoredProcedure supprimer_fournisseur     ******/

create procedure supprimer_fournisseur
	@code_fournisseur nvarchar(50)
	as
		delete from t_fournisseur
			where code_fournisseur=@code_fournisseur


go
/****** Object:  StoredProcedure supprimer_login     ******/

create procedure supprimer_login
	@nom_utilisateur nvarchar(50)
	as
	delete from t_login
		where nom_utilisateur=@nom_utilisateur;
go
create procedure rechercher_facure
@code_facture nvarchar(50)
as
select        
	t_approvisionnement.date_approvisionnement, 
	t_approvisionnement.code_approvisionnement, 
	t_approvisionnement.code_equipement, 
	t_equipement.designation_equipement, 
    t_facture.code_facture, 
	t_facture.date_facture, 
	t_client.noms_client, 
	t_details_facture.qte_vendue, 
	t_details_facture.prix_unitaire, 
	t_details_facture.prix_total
from            
	t_approvisionnement inner join t_details_facture on
		t_approvisionnement.code_approvisionnement = t_details_facture.code_approvisionnement 
		inner join
        t_facture on t_details_facture.code_facture = t_facture.code_facture inner join
                         t_equipement on t_approvisionnement.code_equipement = t_equipement.code_equipement inner join
                         t_client on t_facture.matricule_client = t_client.matricule_client
						 where t_facture.code_facture=@code_facture
go
create table t_stock
(
	numero int identity,
	date_stock date,
	designation nvarchar(50),
	stock_initial decimal,
	qte_entree decimal,
	qte_sortie decimal,
	stock_final decimal,
	constraint pk_stock primary key(numero)
)
go
alter procedure rechercher_stock
as
	select top 500
		date_stock,
		designation,
		stock_initial,
		qte_entree,
		qte_sortie,
		stock_final
	from t_stock
		order by date_stock desc, designation desc
go
insert into t_stock
	(date_stock,designation,stock_initial,qte_entree,qte_sortie,stock_final)
values
	('2017/09/22','DECODEUR SX310',10,5,3,12),
	('2017/09/23','TELECOMMANDE SX310',20,5,3,22),
	('2017/09/23','DECODEUR SX310',12,2,3,11)
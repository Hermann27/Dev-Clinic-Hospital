DROP DATABASE IF EXISTS MLR1;

CREATE DATABASE IF NOT EXISTS MLR1;
USE MLR1;
# -----------------------------------------------------------------------------
#       TABLE : RDV
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS RDV
 (
   ID_AUTO CHAR(32) NOT NULL  ,
   CODE_PAT CHAR(32) NULL  ,
   CODE_PERS CHAR(32) NULL  ,
   DATE_RDV CHAR(32) NULL  ,
   HEURE_RDV CHAR(32) NULL  ,
   MODIF_RDV CHAR(32) NULL  ,
   OBSERVATION CHAR(32) NULL  
   , PRIMARY KEY (ID_AUTO) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE RDV
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_RDV_PATIENT
     ON RDV (CODE_PAT ASC);

CREATE  INDEX I_FK_RDV_PERSONNEL_SOIGNANT_MEDECIN_
     ON RDV (CODE_PERS ASC);

# -----------------------------------------------------------------------------
#       TABLE : CATEGORIE_SOCIETE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CATEGORIE_SOCIETE
 (
   ID CHAR(32) NOT NULL  ,
   CODE CHAR(32) NULL  ,
   INTITULE CHAR(32) NULL  ,
   DESIGNATION CHAR(32) NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE CATEGORIE_SOCIETE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_CATEGORIE_SOCIETE_SOCIETE
     ON CATEGORIE_SOCIETE (CODE ASC);

# -----------------------------------------------------------------------------
#       TABLE : EXAMENS
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS EXAMENS
 (
   CODE_EXAM CHAR(32) NOT NULL  ,
   TYPE_EXAM CHAR(32) NULL  ,
   PRIX_EXAM CHAR(32) NULL  
   , PRIMARY KEY (CODE_EXAM) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : DETAIL_ASSURANCE_SOC
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DETAIL_ASSURANCE_SOC
 (
   ID_AUTO CHAR(32) NOT NULL  ,
   CODE_PRES CHAR(32) NOT NULL  ,
   ID CHAR(32) NOT NULL  ,
   PRIX_PRATIQUER CHAR(32) NULL  
   , PRIMARY KEY (ID_AUTO) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE DETAIL_ASSURANCE_SOC
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_DETAIL_ASSURANCE_SOC_ACTE_PRESTATION
     ON DETAIL_ASSURANCE_SOC (CODE_PRES ASC);

CREATE  INDEX I_FK_DETAIL_ASSURANCE_SOC_CATEGORIE_SOCIETE
     ON DETAIL_ASSURANCE_SOC (ID ASC);

# -----------------------------------------------------------------------------
#       TABLE : ASSURANCE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ASSURANCE
 (
   CODE_ASS CHAR(32) NOT NULL  ,
   NOM_ASS CHAR(32) NULL  ,
   BP_ASS CHAR(32) NULL  ,
   TELEPHONE_ASS CHAR(32) NULL  ,
   TELEX_ASS CHAR(32) NULL  ,
   FAX_ASS CHAR(32) NULL  
   , PRIMARY KEY (CODE_ASS) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : GROUPE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS GROUPE
 (
   CODE_GR CHAR(32) NOT NULL  ,
   CODE_PRES CHAR(32) NOT NULL  ,
   INTITULE CHAR(32) NULL  
   , PRIMARY KEY (CODE_GR) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE GROUPE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_GROUPE_ACTE_PRESTATION
     ON GROUPE (CODE_PRES ASC);

# -----------------------------------------------------------------------------
#       TABLE : SERVICE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SERVICE
 (
   CODE_SERV CHAR(32) NOT NULL  ,
   INTITULE CHAR(32) NULL  ,
   OBSERVATION CHAR(32) NULL  
   , PRIMARY KEY (CODE_SERV) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PATIENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PATIENT
 (
   CODE_PAT CHAR(32) NOT NULL  ,
   CODE CHAR(32) NULL  ,
   CIN CHAR(32) NULL  ,
   NOM CHAR(32) NULL  ,
   PRENOM CHAR(32) NULL  ,
   SEXE CHAR(32) NULL  ,
   DATE_NAISS CHAR(32) NULL  ,
   LIEU_NAISS CHAR(32) NULL  ,
   PROFESSION CHAR(32) NULL  ,
   QUARTIE CHAR(32) NULL  ,
   TELEPHONE CHAR(32) NULL  ,
   EMAIL CHAR(32) NULL  ,
   GROUPE_SANGUN CHAR(32) NULL  ,
   PERSONNE_A_CONTACTER CHAR(32) NULL  
   , PRIMARY KEY (CODE_PAT) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE PATIENT
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_PATIENT_SOCIETE
     ON PATIENT (CODE ASC);

# -----------------------------------------------------------------------------
#       TABLE : DOSSIER_MEDICALE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DOSSIER_MEDICALE
 (
   NUMERO_DOSSIER CHAR(32) NOT NULL  ,
   CODE_ORD CHAR(32) NULL  ,
   CODE_PERS CHAR(32) NULL  ,
   CODE_PAT CHAR(32) NULL  ,
   ANNEE CHAR(32) NULL  ,
   NUMEROREF CHAR(32) NULL  
   , PRIMARY KEY (NUMERO_DOSSIER) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE DOSSIER_MEDICALE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_DOSSIER_MEDICALE_ORDONANCES
     ON DOSSIER_MEDICALE (CODE_ORD ASC);

CREATE  INDEX I_FK_DOSSIER_MEDICALE_PERSONNEL_SOIGNANT_MEDECIN_
     ON DOSSIER_MEDICALE (CODE_PERS ASC);

CREATE  INDEX I_FK_DOSSIER_MEDICALE_PATIENT
     ON DOSSIER_MEDICALE (CODE_PAT ASC);

# -----------------------------------------------------------------------------
#       TABLE : DEPOT_MEDICAMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS DEPOT_MEDICAMENT
 (
   ID_AUTO CHAR(32) NOT NULL  ,
   INTITULE CHAR(32) NULL  ,
   ADRESSE CHAR(32) NULL  ,
   REGIONS CHAR(32) NULL  ,
   PAYS CHAR(32) NULL  ,
   REPONSABLE CHAR(32) NULL  ,
   TELEPHONE CHAR(32) NULL  ,
   EMAIL CHAR(32) NULL  
   , PRIMARY KEY (ID_AUTO) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : SOCIETE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS SOCIETE
 (
   CODE CHAR(32) NOT NULL  ,
   NOM_SOC CHAR(32) NULL  ,
   ADRESSE_SOC CHAR(32) NULL  
   , PRIMARY KEY (CODE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : LABORATOIRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LABORATOIRE
 (
   ID CHAR(32) NOT NULL  ,
   CODE_EXAM CHAR(32) NULL  ,
   NUMERO_DOSSIER CHAR(32) NULL  ,
   DATE CHAR(32) NULL  ,
   OBSERVATION CHAR(32) NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE LABORATOIRE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_LABORATOIRE_EXAMENS
     ON LABORATOIRE (CODE_EXAM ASC);

CREATE  INDEX I_FK_LABORATOIRE_DOSSIER_MEDICALE
     ON LABORATOIRE (NUMERO_DOSSIER ASC);

# -----------------------------------------------------------------------------
#       TABLE : VISITES
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS VISITES
 (
   NUMERO_AUTO CHAR(32) NOT NULL  ,
   NUMERO_DOSSIER CHAR(32) NULL  ,
   CODE_PERS CHAR(32) NULL  ,
   CODE_PRES CHAR(32) NULL  ,
   DATE_VISITE CHAR(32) NULL  ,
   OBSERVATION CHAR(32) NULL  
   , PRIMARY KEY (NUMERO_AUTO) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE VISITES
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_VISITES_DOSSIER_MEDICALE
     ON VISITES (NUMERO_DOSSIER ASC);

CREATE  INDEX I_FK_VISITES_PERSONNEL_SOIGNANT_MEDECIN_
     ON VISITES (CODE_PERS ASC);

CREATE  INDEX I_FK_VISITES_ACTE_PRESTATION
     ON VISITES (CODE_PRES ASC);

# -----------------------------------------------------------------------------
#       TABLE : LIGNE_DOC_STOCK
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS LIGNE_DOC_STOCK
 (
   NUMEROLIGNE CHAR(32) NOT NULL  ,
   CODE_MEC CHAR(32) NOT NULL  ,
   REF CHAR(32) NOT NULL  ,
   QTE CHAR(32) NULL  
   , PRIMARY KEY (NUMEROLIGNE) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE LIGNE_DOC_STOCK
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_LIGNE_DOC_STOCK_MEDICAMENT_INTERNE
     ON LIGNE_DOC_STOCK (CODE_MEC ASC);

CREATE  INDEX I_FK_LIGNE_DOC_STOCK_ENTETE_STOCK
     ON LIGNE_DOC_STOCK (REF ASC);

# -----------------------------------------------------------------------------
#       TABLE : MALADIE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MALADIE
 (
   CODE_MAL CHAR(32) NOT NULL  ,
   FAMILLE_MAL CHAR(255) NULL  ,
   SOUS_FAMILLE_MAL CHAR(255) NULL  ,
   DESIGNATION VARCHAR(255) NULL  ,
   PRIX_TRAIT DECIMAL(13,2) NULL  
   , PRIMARY KEY (CODE_MAL) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : ENTETE_STOCK
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ENTETE_STOCK
 (
   ID_AUTO CHAR(32) NOT NULL  ,
   DATE CHAR(32) NULL  ,
   NUMERO_PIECE CHAR(32) NULL  ,
   REF CHAR(32) NOT NULL  
   , PRIMARY KEY (REF) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE ENTETE_STOCK
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_ENTETE_STOCK_DEPOT_MEDICAMENT
     ON ENTETE_STOCK (ID_AUTO ASC);

# -----------------------------------------------------------------------------
#       TABLE : RECEPTION_CONSULTATION_
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS RECEPTION_CONSULTATION_
 (
   ID CHAR(32) NOT NULL  ,
   CODE_PAT CHAR(32) NOT NULL  ,
   CODE_PERS CHAR(32) NULL  ,
   DATE_CONSULT CHAR(32) NULL  ,
   TYPE_CONSULT CHAR(32) NULL  ,
   OBSERVATION CHAR(32) NULL  ,
   FRAIX_CONSULT CHAR(32) NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE RECEPTION_CONSULTATION_
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_RECEPTION_CONSULTATION__PATIENT
     ON RECEPTION_CONSULTATION_ (CODE_PAT ASC);

CREATE  INDEX I_FK_RECEPTION_CONSULTATION__PERSONNEL_SOIGNANT_MEDECIN_
     ON RECEPTION_CONSULTATION_ (CODE_PERS ASC);

# -----------------------------------------------------------------------------
#       TABLE : TRAITEMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS TRAITEMENT
 (
   ID CHAR(32) NOT NULL  ,
   NUMERO_DOSSIER CHAR(32) NULL  ,
   CODE_MAL CHAR(32) NULL  ,
   OBSERVATION CHAR(32) NULL  ,
   DATE_DEBUT CHAR(32) NULL  ,
   DATE_FIN CHAR(32) NULL  ,
   ETAT_FIN CHAR(32) NULL  
   , PRIMARY KEY (ID) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE TRAITEMENT
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_TRAITEMENT_DOSSIER_MEDICALE
     ON TRAITEMENT (NUMERO_DOSSIER ASC);

CREATE  INDEX I_FK_TRAITEMENT_MALADIE
     ON TRAITEMENT (CODE_MAL ASC);

# -----------------------------------------------------------------------------
#       TABLE : CHAMBRE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CHAMBRE
 (
   CODE_CH CHAR(32) NOT NULL  ,
   LOCALISATION CHAR(32) NULL  ,
   CATEGORIE_CH CHAR(32) NULL  ,
   TYPE_LIT CHAR(32) NULL  ,
   PRIX_CH CHAR(32) NULL  
   , PRIMARY KEY (CODE_CH) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : ACTE_PRESTATION
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ACTE_PRESTATION
 (
   CODE_PRES CHAR(32) NOT NULL  ,
   INTUTLE_PRES CHAR(32) NULL  ,
   LETTRE_CLE CHAR(32) NULL  ,
   PRIX_PRATITIQUER CHAR(32) NULL  
   , PRIMARY KEY (CODE_PRES) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : PERSONNEL_SOIGNANT_MEDECIN_
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS PERSONNEL_SOIGNANT_MEDECIN_
 (
   CODE_PERS CHAR(32) NOT NULL  ,
   CODE_SERV CHAR(32) NOT NULL  ,
   NOM_PERS CHAR(32) NULL  ,
   PRENOM_PERS CHAR(32) NULL  ,
   SEXE CHAR(32) NULL  ,
   GRADE_PERS CHAR(32) NULL  ,
   FONCT CHAR(32) NULL  ,
   TELEPHONE CHAR(32) NULL  ,
   EMAIL CHAR(32) NULL  ,
   ADRESSE CHAR(32) NULL  ,
   DATE_RECRUCT CHAR(32) NULL  
   , PRIMARY KEY (CODE_PERS) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE PERSONNEL_SOIGNANT_MEDECIN_
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_PERSONNEL_SOIGNANT_MEDECIN__SERVICE
     ON PERSONNEL_SOIGNANT_MEDECIN_ (CODE_SERV ASC);

# -----------------------------------------------------------------------------
#       TABLE : UTILISATEURS
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS UTILISATEURS
 (
   LOGIN CHAR(32) NOT NULL  ,
   CODE_PERS CHAR(32) NOT NULL  ,
   PASSWORD CHAR(32) NULL  ,
   PRIVILEGE CHAR(32) NULL  
   , PRIMARY KEY (LOGIN) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE UTILISATEURS
# -----------------------------------------------------------------------------


CREATE UNIQUE INDEX I_FK_UTILISATEURS_PERSONNEL_SOIGNANT_MEDECIN_
     ON UTILISATEURS (CODE_PERS ASC);

# -----------------------------------------------------------------------------
#       TABLE : MEDICAMENT_INTERNE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS MEDICAMENT_INTERNE
 (
   CODE_MEC CHAR(32) NOT NULL  ,
   NOM_MEC CHAR(32) NULL  ,
   PRIX_MEC CHAR(32) NULL  
   , PRIMARY KEY (CODE_MEC) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       TABLE : ORDONANCES
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ORDONANCES
 (
   CODE_ORD CHAR(32) NOT NULL  ,
   CODE_PERS CHAR(32) NOT NULL  ,
   DATE_ORD CHAR(32) NULL  ,
   DETAIL_ORD CHAR(32) NULL  
   , PRIMARY KEY (CODE_ORD) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE ORDONANCES
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_ORDONANCES_PERSONNEL_SOIGNANT_MEDECIN_
     ON ORDONANCES (CODE_PERS ASC);

# -----------------------------------------------------------------------------
#       TABLE : ETRE_HOSPITALISER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ETRE_HOSPITALISER
 (
   CODE_CH CHAR(32) NOT NULL  ,
   NUMERO_DOSSIER CHAR(32) NOT NULL  ,
   DATE_ARRIVE CHAR(32) NULL  ,
   DATE_SORTIE CHAR(32) NULL  ,
   OBSERVATION CHAR(32) NULL  
   , PRIMARY KEY (CODE_CH,NUMERO_DOSSIER) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE ETRE_HOSPITALISER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_ETRE_HOSPITALISER_CHAMBRE
     ON ETRE_HOSPITALISER (CODE_CH ASC);

CREATE  INDEX I_FK_ETRE_HOSPITALISER_DOSSIER_MEDICALE
     ON ETRE_HOSPITALISER (NUMERO_DOSSIER ASC);

# -----------------------------------------------------------------------------
#       TABLE : CONSOMMER
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS CONSOMMER
 (
   CODE_PAT CHAR(32) NOT NULL  ,
   CODE_MEC CHAR(32) NOT NULL  ,
   DATE_CONSO CHAR(32) NULL  ,
   QTE_CONSO CHAR(32) NULL  
   , PRIMARY KEY (CODE_PAT,CODE_MEC) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE CONSOMMER
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_CONSOMMER_PATIENT
     ON CONSOMMER (CODE_PAT ASC);

CREATE  INDEX I_FK_CONSOMMER_MEDICAMENT_INTERNE
     ON CONSOMMER (CODE_MEC ASC);

# -----------------------------------------------------------------------------
#       TABLE : STOCK_MEDICAMENT
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS STOCK_MEDICAMENT
 (
   CODE_MEC CHAR(32) NOT NULL  ,
   ID_AUTO CHAR(32) NOT NULL  ,
   QTE CHAR(32) NULL  
   , PRIMARY KEY (CODE_MEC,ID_AUTO) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE STOCK_MEDICAMENT
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_STOCK_MEDICAMENT_MEDICAMENT_INTERNE
     ON STOCK_MEDICAMENT (CODE_MEC ASC);

CREATE  INDEX I_FK_STOCK_MEDICAMENT_DEPOT_MEDICAMENT
     ON STOCK_MEDICAMENT (ID_AUTO ASC);

# -----------------------------------------------------------------------------
#       TABLE : ASSURANCE_SOCIETE
# -----------------------------------------------------------------------------

CREATE TABLE IF NOT EXISTS ASSURANCE_SOCIETE
 (
   CODE_ASS CHAR(32) NOT NULL  ,
   CODE CHAR(32) NOT NULL  ,
   ID_AUTO CHAR(32) NOT NULL  
   , PRIMARY KEY (CODE_ASS,CODE,ID_AUTO) 
 ) 
 comment = "";

# -----------------------------------------------------------------------------
#       INDEX DE LA TABLE ASSURANCE_SOCIETE
# -----------------------------------------------------------------------------


CREATE  INDEX I_FK_ASSURANCE_SOCIETE_ASSURANCE
     ON ASSURANCE_SOCIETE (CODE_ASS ASC);

CREATE  INDEX I_FK_ASSURANCE_SOCIETE_SOCIETE
     ON ASSURANCE_SOCIETE (CODE ASC);

CREATE  INDEX I_FK_ASSURANCE_SOCIETE_DETAIL_ASSURANCE_SOC
     ON ASSURANCE_SOCIETE (ID_AUTO ASC);


# -----------------------------------------------------------------------------
#       CREATION DES REFERENCES DE TABLE
# -----------------------------------------------------------------------------


ALTER TABLE RDV 
  ADD FOREIGN KEY FK_RDV_PATIENT (CODE_PAT)
      REFERENCES PATIENT (CODE_PAT) ;


ALTER TABLE RDV 
  ADD FOREIGN KEY FK_RDV_PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS)
      REFERENCES PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS) ;


ALTER TABLE CATEGORIE_SOCIETE 
  ADD FOREIGN KEY FK_CATEGORIE_SOCIETE_SOCIETE (CODE)
      REFERENCES SOCIETE (CODE) ;


ALTER TABLE DETAIL_ASSURANCE_SOC 
  ADD FOREIGN KEY FK_DETAIL_ASSURANCE_SOC_ACTE_PRESTATION (CODE_PRES)
      REFERENCES ACTE_PRESTATION (CODE_PRES) ;


ALTER TABLE DETAIL_ASSURANCE_SOC 
  ADD FOREIGN KEY FK_DETAIL_ASSURANCE_SOC_CATEGORIE_SOCIETE (ID)
      REFERENCES CATEGORIE_SOCIETE (ID) ;


ALTER TABLE GROUPE 
  ADD FOREIGN KEY FK_GROUPE_ACTE_PRESTATION (CODE_PRES)
      REFERENCES ACTE_PRESTATION (CODE_PRES) ;


ALTER TABLE PATIENT 
  ADD FOREIGN KEY FK_PATIENT_SOCIETE (CODE)
      REFERENCES SOCIETE (CODE) ;


ALTER TABLE DOSSIER_MEDICALE 
  ADD FOREIGN KEY FK_DOSSIER_MEDICALE_ORDONANCES (CODE_ORD)
      REFERENCES ORDONANCES (CODE_ORD) ;


ALTER TABLE DOSSIER_MEDICALE 
  ADD FOREIGN KEY FK_DOSSIER_MEDICALE_PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS)
      REFERENCES PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS) ;


ALTER TABLE DOSSIER_MEDICALE 
  ADD FOREIGN KEY FK_DOSSIER_MEDICALE_PATIENT (CODE_PAT)
      REFERENCES PATIENT (CODE_PAT) ;


ALTER TABLE LABORATOIRE 
  ADD FOREIGN KEY FK_LABORATOIRE_EXAMENS (CODE_EXAM)
      REFERENCES EXAMENS (CODE_EXAM) ;


ALTER TABLE LABORATOIRE 
  ADD FOREIGN KEY FK_LABORATOIRE_DOSSIER_MEDICALE (NUMERO_DOSSIER)
      REFERENCES DOSSIER_MEDICALE (NUMERO_DOSSIER) ;


ALTER TABLE VISITES 
  ADD FOREIGN KEY FK_VISITES_DOSSIER_MEDICALE (NUMERO_DOSSIER)
      REFERENCES DOSSIER_MEDICALE (NUMERO_DOSSIER) ;


ALTER TABLE VISITES 
  ADD FOREIGN KEY FK_VISITES_PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS)
      REFERENCES PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS) ;


ALTER TABLE VISITES 
  ADD FOREIGN KEY FK_VISITES_ACTE_PRESTATION (CODE_PRES)
      REFERENCES ACTE_PRESTATION (CODE_PRES) ;


ALTER TABLE LIGNE_DOC_STOCK 
  ADD FOREIGN KEY FK_LIGNE_DOC_STOCK_MEDICAMENT_INTERNE (CODE_MEC)
      REFERENCES MEDICAMENT_INTERNE (CODE_MEC) ;


ALTER TABLE LIGNE_DOC_STOCK 
  ADD FOREIGN KEY FK_LIGNE_DOC_STOCK_ENTETE_STOCK (REF)
      REFERENCES ENTETE_STOCK (REF) ;


ALTER TABLE ENTETE_STOCK 
  ADD FOREIGN KEY FK_ENTETE_STOCK_DEPOT_MEDICAMENT (ID_AUTO)
      REFERENCES DEPOT_MEDICAMENT (ID_AUTO) ;


ALTER TABLE RECEPTION_CONSULTATION_ 
  ADD FOREIGN KEY FK_RECEPTION_CONSULTATION__PATIENT (CODE_PAT)
      REFERENCES PATIENT (CODE_PAT) ;


ALTER TABLE RECEPTION_CONSULTATION_ 
  ADD FOREIGN KEY FK_RECEPTION_CONSULTATION__PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS)
      REFERENCES PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS) ;


ALTER TABLE TRAITEMENT 
  ADD FOREIGN KEY FK_TRAITEMENT_DOSSIER_MEDICALE (NUMERO_DOSSIER)
      REFERENCES DOSSIER_MEDICALE (NUMERO_DOSSIER) ;


ALTER TABLE TRAITEMENT 
  ADD FOREIGN KEY FK_TRAITEMENT_MALADIE (CODE_MAL)
      REFERENCES MALADIE (CODE_MAL) ;


ALTER TABLE PERSONNEL_SOIGNANT_MEDECIN_ 
  ADD FOREIGN KEY FK_PERSONNEL_SOIGNANT_MEDECIN__SERVICE (CODE_SERV)
      REFERENCES SERVICE (CODE_SERV) ;


ALTER TABLE UTILISATEURS 
  ADD FOREIGN KEY FK_UTILISATEURS_PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS)
      REFERENCES PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS) ;


ALTER TABLE ORDONANCES 
  ADD FOREIGN KEY FK_ORDONANCES_PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS)
      REFERENCES PERSONNEL_SOIGNANT_MEDECIN_ (CODE_PERS) ;


ALTER TABLE ETRE_HOSPITALISER 
  ADD FOREIGN KEY FK_ETRE_HOSPITALISER_CHAMBRE (CODE_CH)
      REFERENCES CHAMBRE (CODE_CH) ;


ALTER TABLE ETRE_HOSPITALISER 
  ADD FOREIGN KEY FK_ETRE_HOSPITALISER_DOSSIER_MEDICALE (NUMERO_DOSSIER)
      REFERENCES DOSSIER_MEDICALE (NUMERO_DOSSIER) ;


ALTER TABLE CONSOMMER 
  ADD FOREIGN KEY FK_CONSOMMER_PATIENT (CODE_PAT)
      REFERENCES PATIENT (CODE_PAT) ;


ALTER TABLE CONSOMMER 
  ADD FOREIGN KEY FK_CONSOMMER_MEDICAMENT_INTERNE (CODE_MEC)
      REFERENCES MEDICAMENT_INTERNE (CODE_MEC) ;


ALTER TABLE STOCK_MEDICAMENT 
  ADD FOREIGN KEY FK_STOCK_MEDICAMENT_MEDICAMENT_INTERNE (CODE_MEC)
      REFERENCES MEDICAMENT_INTERNE (CODE_MEC) ;


ALTER TABLE STOCK_MEDICAMENT 
  ADD FOREIGN KEY FK_STOCK_MEDICAMENT_DEPOT_MEDICAMENT (ID_AUTO)
      REFERENCES DEPOT_MEDICAMENT (ID_AUTO) ;


ALTER TABLE ASSURANCE_SOCIETE 
  ADD FOREIGN KEY FK_ASSURANCE_SOCIETE_ASSURANCE (CODE_ASS)
      REFERENCES ASSURANCE (CODE_ASS) ;


ALTER TABLE ASSURANCE_SOCIETE 
  ADD FOREIGN KEY FK_ASSURANCE_SOCIETE_SOCIETE (CODE)
      REFERENCES SOCIETE (CODE) ;


ALTER TABLE ASSURANCE_SOCIETE 
  ADD FOREIGN KEY FK_ASSURANCE_SOCIETE_DETAIL_ASSURANCE_SOC (ID_AUTO)
      REFERENCES DETAIL_ASSURANCE_SOC (ID_AUTO) ;


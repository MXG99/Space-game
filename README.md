# Space-game
Lunar lander arcade game developed in Unity
Ministerul Educaţiei, Cercetării, Tineretului şi Sportului

Colegiul Național Vlaicu Vodă, Curtea de Argeș

Profil Matematică – Informatică

intensiv Informatică

![](RackMultipart20210323-4-1vcviaz_html_3f2a21e1b28b13b9.gif)

# lucrare de atestat

![](RackMultipart20210323-4-1vcviaz_html_ee47b16dc9ea7944.png)

![](RackMultipart20210323-4-1vcviaz_html_3d7e6bf4c0671732.gif)

2019

Candidat: Balotă GEORGE

INDRUMATOR: Prof. ION UNGUREANU

![](RackMultipart20210323-4-1vcviaz_html_700dc6d1d89c2a27.gif)

#
# Cuprins

[Introducere 2](#_Toc4325866)

[1.1Ce este **C#**? 2](#_Toc4325867)

[1.2 Ce este **Unity**? 3](#_Toc4325868)

[Descrierea lucrării 4](#_Toc4325869)

[2.1 Prima Scena 6](#_Toc4325870)

[2.2 Scena 2 7](#_Toc4325871)

[2.3 Controlul navetei 8](#_Toc4325872)

[Utilizare 9](#_Toc4325873)

[3.1 Resurse minime: 9](#_Toc4325874)

# ![](RackMultipart20210323-4-1vcviaz_html_4ed1fecb14f28efd.png)
## Introducere

  1.
## Ce este **C#**?

**Limbajul C#** a fost dezvoltat în cadrul Microsoft. Principalii creatori ai limbajului sunt Anders Hejlsberg, Scott Wiltamuth şi Peter Golde. Prima implementare C# larg distribuită a fost lansată de către Microsoft ca parte a iniţiativei .NET în iulie 2000. Din acel moment, se poate vorbi despre o evoluţie spectaculoasă. Mii de programatori de C, C++ şi Java, au migrat cu uşurinţă spre C#, graţie asemănării acestor limbaje, dar mai ales calităţilor noului limbaj. La acest moment, C# şi-a câştigat şi atrage în continuare numeroşi adepţi, devenind unul dintre cele mai utilizate limbaje din lume.

Creatorii C# au intenţionat să înzestreze limbajul cu mai multe facilităţi. Succesul de care se bucură în prezent, confirmă calităţile sale:

- Este un limbaj de programare simplu, modern, de utilitate generală, cu productivitate mare în programare.
- Este un limbaj orientat pe obiecte.
- Permite dezvoltarea de aplicaţii industriale robuste, durabile.
- Oferă suport complet pentru dezvoltarea de componente software, foarte necesare de pildă în medii distribuite. De altfel, se poate caracteriza C# ca fiind nu numai orientat obiect, ci şi orientat spre componente.

## 1.2 Ce este **Unity**?

![](RackMultipart20210323-4-1vcviaz_html_ea1659726ef72abb.png)

**Unity** , cel mai popular editor de jocuri video din lume, este folosit de mii de dezvoltatori de pe tot globul datorita gamei complete de functii disponibile si capacitatii de adaptare la peste 25 de platforme online sau mobile. 34% dintre cele mai bune 1.000 de jocuri mobile gratuite din lume au fost dezvoltate folosind Unity, miliarde de descarcari de jocuri construite cu ajutorul acestui editor inregistrandu-se in fiecare an. Printre jocurile cele mai populare dezvoltate cu ajutorul Unity se numara Hearthstone, Temple Run sau Angry Birds 2.

![](RackMultipart20210323-4-1vcviaz_html_f0d47ea1e68774ff.png)

# ![](RackMultipart20210323-4-1vcviaz_html_e8017ecb00e56e9b.png)
## Descrierea lucrării

Space este inspirat din clasicul joc de tip &quot;arcade&quot; Lunar Lander.

Jocul Lunar Lander a dat numele unui nou gen de jocuri in care jucătorul controlează o nava spațiala aflata in cădere spre suprafața Lunii sau a altor corpuri cerești. Jucătorul trebuie sa manevreze propulsoarele navei astfel încât sa aterizeze in siguranța.

Primul joc Lunar Lander a fost un joc pe baza de text, scris in limbajul de programare FOCAL
## (
**F** ormulating  **O** n-Line  **C** alculations in  **A** lgebraic  **L** anguage) pentru minicomputer-ul Digital Equipment Corporation (DEC) PDP-8, de studentul Jim Storer in anul 1969.

Doua alte versiuni au fost lansate ulterior de către alți dezvoltatori in limbajul BASIC.

![](RackMultipart20210323-4-1vcviaz_html_6765aad470ac5ad1.png)

![](RackMultipart20210323-4-1vcviaz_html_ee47b16dc9ea7944.png)

Space reprezintă o readaptare moderna a jocului Lunar Lander. Fiind o creație recenta, jocul Space profita de puterea de calcul oferita de calculatoarele din aceasta perioada si inovează prin aspect vizual si atmosfera plăcută data de coloana sonoră oferită de compozitorul Lucas King.

![](RackMultipart20210323-4-1vcviaz_html_d10da80cb96b63b0.jpg)

## 2.1 Prima Scena

-Ce este un **Asset**?

Un asset reprezintă o resursă publica menită sa faciliteze munca unui dezvoltator in crearea de conținut.

Unity are propria librărie de asset-uri numita Asset Store.

Prima scena este reprezentata de meniul principal. Acesta a fost realizat cu ajutorul uneltelor oferite de Unity, iar pentru text a fost folosit asset-ul Text Mesh Pro, disponibil gratuit pe Asset Store.

![](RackMultipart20210323-4-1vcviaz_html_bd135f21ce3bd2b6.png)

## 2.2 Scena 2

Scena 2 reprezintă primul nivel al acestui joc. Space fiind încă un prototip, acesta are doar doua nivele.

![](RackMultipart20210323-4-1vcviaz_html_1ed72267c76afd3e.png)

Pentru crearea acestui nivel au fost folosite doua asset-uri. MK-Glow, pentru o mai buna generare a luminii ambientale si Standard Assets, pentru efectele de post-proscessing.

![](RackMultipart20210323-4-1vcviaz_html_e7b978cdbf188e3a.png) ![](RackMultipart20210323-4-1vcviaz_html_8dcbb901f601d7bd.png)

MK-Glow ACTIV MK-Glow INACTIV

## 2.3 Scena 3

Scena 3 sau ultimul nivel al jocului este reprezentat de un nivel mai lung, in care sunt prezente toate elementele jocului Space. Acesta are in plus fata de primul nivel un checkpoint si o noua mecanica a lavei.

![](RackMultipart20210323-4-1vcviaz_html_dfaf29866d2e55d4.png) ![](RackMultipart20210323-4-1vcviaz_html_5e47d4ac03f3be41.png)

_In timpul jocului_

_In editor_

##

##

##

##

##

##

##

##

##

##

##

##

##

##

##

##

##

##

## 2.4 Controlul navetei

Codul responsabil pentru controlul navetei:

![](RackMultipart20210323-4-1vcviaz_html_ecafa0c9df524c3b.gif)

#
## Utilizare

## 3.1 Resurse minime:

Hardware:

-Procesor(CPU): 2.5+ GHZ Dual Core

-Memorie (RAM): 2 GB

-Spatiu Liber: 500 MB

-Sistem de Operare: Windows 7/8/8.1/10

## 3.2 Programe Utilizate:

- Unity 2018

- Visual Studio Code

- Photoshop CC

Nainstaloval jsem VS
Zkouknul github video a vytvořil folder (to bylo docela náročné)
Podívám se na tutoriál k C# a podle toho se uvidí, zda jsem schopen začít něco tvořit ve scenario.md 

SOFTWARE PRO TAJEMNÍKA ÚSTAVU

tajemník pracuje v excelu a je z toho špatný, dělá chyby a je to moc práce. chce aplikaci, která bude řídit vytíženost zaměstnanců ústavu a všechno se to udělá za něj, aby se mohl věnovat cestě meče.

otázka: učitel učí všechno? štítek (skupina/počet studentů v předmětu) lze přidat libovolně komukoliv?

1. existuje databáze zaměstananců (jméno, příjmení, tel1, tel2, email, je doktorand?, úvazek 0-1, kolik pracovních bodů zabírá výuka v ČJ/EN)
2. existuje databáze předmětů (zkratka, název, poč.hod. přednášek, ph seminnářů, ph přednášek, ČJ/EN, typ studia, ročník, defaultni velikost skupiny)
3. studijní skupina (zkratka, název, typ studia, ročník, L/Z, počet studentů, bc/mgr) vygenerují se z tajemníkova tajemného xml pro další rok samy
4. štítek - vygeneruje se po zadání studijních skupin. štítek zanamená základní studijní jednotku (studijní skupina dělěno počtem def. studentů z předmětu)
5. hlavní tajemníkova zbraň, formulář, kde šíbuje se štítky. je tam jméno učitele (všichni dohromady nebo list?), počet štítků, které dostal (nějak zvyraznění under a overfitovaní učitelé?), velký pool štítků, které musí být přiřazeny, počet hodin/bodů, které to dělá/které mu zbyvají/přebývají, počasí z openweather api a zdali nemá někdo svátek. (ještě něco se zkouškama)

# PAC3 - Joc Plataformes 3D

# Programació en Unity 3D

### Dates importants de la PAC3

Data de publicació de l'enunciat: 13/05/2024

Data límit d'entrega: 16/06/2024

Data de qualificació: 08/07/2024

### Llibreries necessàries per fer les pràctiques
Aquesta pràctica la realitzarem utilitzant el motor de videojocs Unity 3D en la seva versió **2022.3.20f1 LTS.**

### Sistemes operatius acceptats
Us recomanem que realitzeu les pràctiques en un entorn Windows o Mac OS. Si necessiteu llicències de Windows, Microsoft Visual Studio o qualsevol altre programari, comenteu-ho al fòrum de l'assignatura i us indicarem si des de la UOC us les podem proporcionar.

### Normes d'ús de models d'Intel·ligència Artificial

En aquesta activitat només es permet un ús limitat d'eines d'intel·ligència artificial. Concretament en el context de les arts i el disseny, les eines d'IA, tant textuals com visuals, poden servir per generar i esbossar idees, contextualitzar conceptes, plantejar prototips o combinar elements de manera innovadora o alternativa. En cas d'utilitzar aquestes eines, és necessari explicitar i citar correctament el seu ús en l'elaboració del treball. Això implica indicar en cada apartat de l'activitat entregada quines eines s'han utilitzat, els objectius, els prompts que s'han emprat, la resposta obtinguda i el procés que s'ha seguit per revisar i editar la sortida. Per fer-ho correctament, consulta la guia [¿Cómo citar la IA en los trabajos?](https://openaccess.uoc.edu/bitstream/10609/148823/2/U2_17_GuiaCitarIA_ESP.pdf). En el pla docent i en la [Web sobre integritat acadèmica i plagi de la UOC](https://campus.uoc.edu/estudiant/microsites/plagi/es/index.html) trobaràs informació sobre què es considera conducta irregular i les conseqüències que pot tenir.

Recorda també que en cas d'usar eines d'IA generativa, no s'ha de proporcionar informació personal, confidencial o protegida per propietat intel·lectual. Tingueu en compte que un ús inadequat de la IA generativa, com la falta de revisió de la resposta obtinguda o la falta de citació de les eines utilitzades, serà considerada una conducta irregular en l'avaluació. En cas de dubte, consulta amb el professorat col·laborador.

### Què s'ha de lliurar?

Es haurà de pujar el projecte funcionant sense errors al GitLab, i aquest haurà de contenir TOTS els següents elements:

• Un TAG identificatiu (PAC3) a la versió final que voleu que sigui avaluada.

• Un fitxer README.md que expliqui com executar el projecte si hi ha algun requisit extra, així com unes instruccions que expliquin els controls del joc o si cal fer alguna acció específica per poder jugar-lo.

• En aquest mateix Readme, s'haurà d'incloure una descripció explicant quines parts heu implementat i com ho heu fet.

• Així com també un **enllaç a un vídeo** que ensenyi i lliste els punts que s'han implementat i el seu funcionament.


### Descripció del joc proposat

Seguint el fil del document "Un joc de plataformes 3D", us proposem que implementeu un joc en tercera persona en el qual el jugador hagi d'escapar d'una invasió zombie. Un estil de joc similar al Dead Rising (veure [vídeo](https://www.youtube.com/watch?v=If0rFpcowwY)).

Els punts bàsics que heu de implementar són:

1.	Crear un petit entorn urbà obert (un poblet o una ciutat petita) on transcorrerà l'acció.
2.	El personatge ha de tenir una pistola per disparar en línia recta cap endavant sempre (no cal apuntar).
3.	El personatge ha d'estar completament animat. Idle, caminar, córrer, saltar, girar, disparar, rebre impacte i morir. 
4.	Tant la quantitat de vida com la munició sempre han de ser visibles per pantalla (HUD).
5.	Els enemics seran zombies que tindran una IA similar als drons: aniran passejant per la ciutat i quan el jugador estigui a prop aniran corrent cap al personatge i l'atacaran cos a cos quan l'atrapin.
6.	Els enemics han de tenir animació de caminar, atacar, morir i rebre impacte.
7.	Hi haurà vianants caminant de manera autònoma per la ciutat. Els vianants han de fugir dels zombies si es troben a prop. 
8.	Hi haurà cotxes circulant de manera autònoma per la ciutat. A més, podrem robar un cotxe i circular amb ell. 
9.	Posar sistemes de partícules quan et fereixen o quan un zombie és colpejat o mor. 
10.	Han d'haver-hi objectes que donguin 'vida' i 'munició' repartits per l'escenari. 
11.	El joc ha de tenir un menú complet que contingui com a mínim les següents funcionalitats:

• Iniciar partida

• Opcions (aquí tenen cabuda opcions com ara gràfics, àudio, idioma...) 

• pantalla de game over i que en morir poguem reiniciar el nivell.

Els punts que valorarem són:

1.	Definir una bona estructura de dades per desar la informació del joc.
2.	Claredat i senzillesa en el codi.
3.	Bona documentació i explicació del treball realitzat.

Els punts opcionals que podeu implementar un cop implementats els punts anteriors són:

1.	Crear situacions on sigui necessari saltar per arribar a certes zones.
2.	Afegir noves armes com grenades o una escopeta.
3.	El joc ha d'estar sonoritzat completament. 
4.	Fer diferents tipus de zombies. Més forts, resistents o ràpids.
5.	Crear la possibilitat de poder apuntar manualment en disparar.
6.	Crear algun tipus de puzle on sigui necessari trobar una clau per obrir una nova zona. Aquesta clau la pot deixar algun zombie 'boss' en morir.
7.	Que el jugador tingui una altra arma, un ganivet o espasa per enfrontar-se als zombies cos a cos.
8.	Els enemics en morir podrien deixar objectes a terra. 
9.	Si els vianants són atrapats per un zombie, que es transformin en zombie també.
10. Si atropellem els zombies o els vianants, aquests haurien d'explotar.
11.	Els zombies aniran apareixent per la ciutat de manera aleatòria o en punts concrets a mesura que el jugador els vagi matant o cada cert temps predefinit. Com més temps portem jugant més ràpid han d'aparèixer. La idea és fer un survival que cada vegada sigui més difícil sobreviure.

Com a punt opcional extra també teniu l'opció de fer que el cap i una mica el tors del personatge mirin automàticament cap als elements que tingui a una certa distància utilitzant l'**Animation Rigging** de Unity.

Per implementar aquest últim punt, us recomanem les següents fonts d'informació oficials on trobareu tot el necessari per començar a treballar amb l'Animation Rigging:

- [Unity Documentation - Manual](https://docs.unity3d.com/Manual/com.unity.animation.rigging.html)

- [Unity Learn - Working with Animation Rigging](https://learn.unity.com/tutorial/working-with-animation-rigging)

- [Unity Blog - What is Rigging in Animation?](https://unity.com/solutions/rigging-animation)

Un altre punt extra el podeu aconseguir utilitzant el sistema de **il·luminació global** de Unity, 'bakejant' les llums i l'ambient occlusion.   
Per entendre com funciona i configurar la il·luminació us recomanem les següents fonts d'informació on trobareu tot el necessari per començar a treballar amb la il·luminació global:

- [Unity Documentation - Lighting - Manual](https://docs.unity3d.com/Manual/LightingOverview.html)

- [Unity Documentation - Lightmappers - Manual](https://docs.unity3d.com/Manual/Lightmappers.html)

- [Unity Documentation - Baked Lights - Manual](https://docs.unity3d.com/Manual/LightMode-Baked.html)

- [Unity Documentation - Ambient Occlusion - Manual](https://docs.unity3d.com/2022.3/Documentation/Manual/LightingBakedAmbientOcclusion.html)

- [Unity Learn - Introduction to Lighting and Rendering](https://learn.unity.com/tutorial/introduction-to-lighting-and-rendering-2019-3#)

- [Unity Learn - Working with Lighting in Unity](https://learn.unity.com/project/working-with-lighting-in-unity)

- [Unity Learn - Lighting Optimization with Precomputed Realtime GI](https://learn.unity.com/project/lighting-optimization-with-precomputed-realtime-gi)

- [Unity Youtube - How to build Lightmaps](https://www.youtube.com/watch?v=KJ4fl-KBDR8&ab_channel=Unity)

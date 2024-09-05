# Mono-projekt
Za Web API - 
- Ubaci AuthorController u mapu s controllerima.
- Umjesto foreach-a u svim metodama koristiti Linq i metode kao što su Any, Firts, FirstOrDefault itd.
- Nije potrebno bacati exception ako nije autor pronađen nego vratiti BadRequest.
- Post metoda treba kroz Body request a poslati objekt, a ne ga hardcodirati u kodu.
- Zašto u update-u authoru stavljamo ime na ""?
- Sve metode trebaju imati IActionResult povratni tip.

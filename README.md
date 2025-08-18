Se cere o aplicatie de tip console care primeste 2 parametrii ca input de la user:
- site valid (e.g.: "https://www.dailymail.co.uk/")
- tag type ("video" / "audio" / "source")
Aplicatia trebuie sa faca site crawling in asa fel incat sa returneze numarul de aparatii al html tag-uri de tipul indicat prin user input 'tag type'. Procesul de crawling se va realiza pe un thread separat fata de cel main. Se urmareste utilizarea unui parameterized thread.  

# Data Repo

Data for the initial load of whichever database is to be used.
Data is in json files for various star wars data types. Schema and example included for website query IDE use.

Data was based on [swapi](https://www.swapi.dev) data and expanded using the following sources

* [Rottent Tomatoes](https://www.rottentomatoes.com)
* [IMDB](https://www.imdb.com)
* [Wikipedia](https://www.wikipedia.com)
* [IGN Star Wars Wiki](https://www.ign.com/wikis/star-wars)


## Notes

****

## Data is very incomplete

## null vs empty value

The following json denotes
* A model whose description has never been checked/recorded
* A model whise uris has never been checked/recorded

```
{
  "name": "Luke",
  "description": null,
  "uris" : null,
}
```

The following json denotes
* A model with no recorded description
* A model with no recorded uris

```
{
  "name": "Luke",
  "description": "",
  "uris": []
}
```
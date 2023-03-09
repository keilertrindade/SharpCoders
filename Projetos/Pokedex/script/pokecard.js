const baseURL = 'https://pokeapi.co/api/v2/pokemon/';
const pokemonID = new URLSearchParams(window.location.search).get('pokemon');

function captlizePokemonName(pokemonName){
    return pokemonName[0].toUpperCase() + pokemonName.substring(1);
}


function getInformationsPokemon(pokemonURL){
    let informationPokemon = fetch(pokemonURL)
    .then((resp) => resp.json())
    .then(function (data) {
    
        return data;
        
    })
    .catch(function (error) {
        console.log(error);
        console.log("you've met with a terrible Error, haven't you?");
        
    });
    
    return informationPokemon;
    }

    function populatePokemonInformations(pokemonID){
    
        let pokemonInformations = getInformationsPokemon(baseURL+pokemonID);
    
            var cardPokemon = document.querySelector(".main-card-pokemon");
            console.log(pokemonInformations);
            
            pokemonInformations.then(valor => {
                         cardPokemon.querySelector('#pokemon-image img').setAttribute('src',valor.sprites.other["official-artwork"].front_default);
            
                        cardPokemon.querySelector('#numero-pokedex').innerHTML = 'Número: '+ valor.id;
            
                        cardPokemon.querySelector('#pokemon-name').innerHTML =  captlizePokemonName(valor.name);
                        
                        var divPokemonCardType = cardPokemon.querySelector('#pokemon-types')

                        for(let typeCount = 0; typeCount < valor.types.length; typeCount++){
                            var pokemonTypeImg = document.createElement('img')
                            pokemonTypeImg.classList.add('card-type')
                            var pokemonType = valor.types[typeCount].type.name;
                            
                            pokemonTypeImg.src="assets/img/pokemon-type-cards/" + pokemonType + ".png";
                            
                            divPokemonCardType.appendChild(pokemonTypeImg)
                        }

                        cardPokemon.querySelector("#stats-altura .stats-value").innerHTML = (valor.height /10) + " m";

                        cardPokemon.querySelector("#stats-peso .stats-value").innerHTML = (valor.weight /10) + " kg";

               /*          var divPokemonCardWeakness = cardPokemon.querySelector('#pokemon-weakness')

                        for(let typeCount = 0; typeCount < valor.types.length; typeCount++){
                            var pokemonTypeImg = document.createElement('img')
                            pokemonTypeImg.classList.add('card-type')
                            var pokemonType = valor.types[typeCount].type.name;
                            
                            pokemonTypeImg.src="assets/img/pokemon-type-cards/" + pokemonType + ".png";
                            
                            divPokemonCardWeakness.appendChild(pokemonTypeImg)
                        }
     */

                })
           
           
    }

populatePokemonInformations(pokemonID)
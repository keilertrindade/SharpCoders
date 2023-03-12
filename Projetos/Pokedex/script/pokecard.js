const baseURL = 'https://pokeapi.co/api/v2/pokemon/';
const pokemonID = new URLSearchParams(window.location.search).get('pokemon');

function captlizeName(name){

    if(name.includes("-")){
        let index = name.search("-")
        return name[0].toUpperCase() + name.substring(1,index+1) + captlizeName(name.substring(index+1));
    }

    return name[0].toUpperCase() + name.substring(1);
}

function loadingTypesJSON(){
    let typesJson = fetch("../assets/types.json")
    .then((resp) => resp.json())
    .then(function (data) {
        return data;
    });

    return typesJson;
}

function createTypesStrenghsAndWeakness(pokemonTypesArray, cardPokemon){
    const typesJson = loadingTypesJSON();
    let weaknessesList = new Set();
    let resistancesList = new Set();
    let imuneList = new Set();

    typesJson.then(valor => {
        for(const element of valor){
            if(pokemonTypesArray.includes(element.name)){
                element.weaknesses.forEach(item => weaknessesList.add(item))
                element.resistances.forEach(item => resistancesList.add(item))
                element.immunes.forEach(item => imuneList.add(item))
            }
        }

        let divPokemonWeakenesses = cardPokemon.querySelector('#pokemon-weaknessess');

        resistancesList.forEach(resistance => {
            if (weaknessesList.has(resistance)){
                weaknessesList.delete(resistance);
            }
        })
        
        weaknessesList.forEach(weaknesses => {
            let pokemonTypeImg = document.createElement('img');
            pokemonTypeImg.classList.add('card-type');
            pokemonTypeImg.src="assets/img/pokemon-type-cards/" + weaknesses + ".png";
            divPokemonWeakenesses.appendChild(pokemonTypeImg);
        })
        
        if(imuneList.size > 0){
            console.log(imuneList);
            let divPokemonInfos = cardPokemon.querySelector('#pokemon-infos');
            let pokemonImunesSection = document.createElement('div');
            pokemonImunesSection.setAttribute("id", "pokemon-imunes-section");
            
            let pokemonImunesHeader = document.createElement('h4');
            pokemonImunesHeader.innerText = "Imune";
            pokemonImunesSection.appendChild(pokemonImunesHeader);

            pokemonImunesListDiv  = document.createElement('div');
            pokemonImunesListDiv.setAttribute("id", "pokemon-imunes");
            pokemonImunesSection.appendChild(pokemonImunesListDiv);


            imuneList.forEach(imune => {
                let pokemonTypeImg = document.createElement('img');
                pokemonTypeImg.classList.add('card-type');
                pokemonTypeImg.src="assets/img/pokemon-type-cards/" + imune + ".png";
                pokemonImunesListDiv.appendChild(pokemonTypeImg);
            })

            divPokemonInfos.appendChild(pokemonImunesSection);
       }
    })

}

function createStatsGraph(pokemonStats, cardPokemon){

        
        let pokemonStatsObject = {};
        pokemonStats.forEach(element => {
            pokemonStatsObject[captlizeName(element.stat.name)] = element.base_stat;
        });
        console.log(pokemonStatsObject)
        console.log(pokemonStats)
        let ctx = cardPokemon.querySelector("#pokemon-stats-graph").getContext('2d');
        Chart.defaults.color = '#fff';
        Chart.defaults.font.size = 11;
        const graph = new Chart(ctx, {
            type: 'bar',
            data: {
            labels: Object.keys(pokemonStatsObject),
            datasets: [
                {
                    label: 'Stats',
                    data: Object.values(pokemonStatsObject)
                },
            ],
          },
          options:{
            scales:{
                y:{
                    min: 00,
                    max: 250,
                    /* display: false */
                }
            },
            backgroundColor: [
                'rgba(255, 89, 89, 0.6)',  // Bar 1
                'rgba(245, 172, 120, 0.6)',  // Bar 2
                'rgba(250, 224, 120, 0.6)',  // Bar 3
                'rgba(157, 183, 245, 0.6)',  // Bar 4
                'rgba(167, 219, 141, 0.6)', // Bar 5
                'rgba(250, 146, 178, 0.6)'   // Bar 6
            ],
            borderWidth: 1,
            borderColor: 'black',          
            plugins:{
                legend:{
                    display: false
            },
            customCanvasBackgroundColor:{
                color: 'lightGreen'
            }
            }         
          }
        });
        
        
}

function loadingMissingNo(){

    const statsMissingNo = [
        {
          "base_stat": 0,
          "effort": 0,
          "stat": {
            "name": "hp",
            "url": "https://pokeapi.co/api/v2/stat/1/"
          }
        },
        {
          "base_stat": 0,
          "effort": 3,
          "stat": {
            "name": "attack",
            "url": "https://pokeapi.co/api/v2/stat/2/"
          }
        },
        {
          "base_stat": 0,
          "effort": 0,
          "stat": {
            "name": "defense",
            "url": "https://pokeapi.co/api/v2/stat/3/"
          }
        },
        {
          "base_stat": 0,
          "effort": 0,
          "stat": {
            "name": "special-attack",
            "url": "https://pokeapi.co/api/v2/stat/4/"
          }
        },
        {
          "base_stat": 0,
          "effort": 0,
          "stat": {
            "name": "special-defense",
            "url": "https://pokeapi.co/api/v2/stat/5/"
          }
        },
        {
          "base_stat": 0,
          "effort": 0,
          "stat": {
            "name": "speed",
            "url": "https://pokeapi.co/api/v2/stat/6/"
          }
        }
      ];

    let cardPokemon = document.querySelector(".main-card-pokemon");
    cardPokemon.querySelector('#pokemon-image img').setAttribute('src','assets/img/MissingNo.jpg');
    cardPokemon.querySelector('#numero-pokedex').innerHTML = 'Número: ???';
    cardPokemon.querySelector('#pokemon-name').innerHTML =  'MissingNo';
    cardPokemon.querySelector('#pokemon-description').innerHTML = "コメント さくせいちゅう";
    cardPokemon.querySelector('#stats-altura .stats-value').innerHTML = "???";
    cardPokemon.querySelector('#stats-categoria .stats-value').innerHTML = "??? Pokémon ";
    cardPokemon.querySelector('#stats-peso .stats-value').innerHTML = "???";
    cardPokemon.querySelector('#stats-habilidade').innerHTML = " ";
    cardPokemon.querySelector('#pokemon-weakness-section').innerHTML = " ";
    cardPokemon.querySelector('#pokemon-types-section').innerHTML = " ";

    createStatsGraph(statsMissingNo, cardPokemon)

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
    
            let cardPokemon = document.querySelector(".main-card-pokemon");
            
            pokemonInformations.then(valor => {
                      if(valor == undefined){
                        loadingMissingNo();
                        return;
                      }
                        if(valor.sprites.other["official-artwork"].front_default == null){
                            cardPokemon.querySelector('#pokemon-image img').setAttribute('src','assets/img/pokeball-open.png');
                        }else{
                            cardPokemon.querySelector('#pokemon-image img').setAttribute('src',valor.sprites.other["official-artwork"].front_default);
                        }
                        
            
                        cardPokemon.querySelector('#numero-pokedex').innerHTML = 'Número: '+ valor.id;
            
                        cardPokemon.querySelector('#pokemon-name').innerHTML =  captlizeName(valor.name);
                        
                        let divPokemonCardType = cardPokemon.querySelector('#pokemon-types')
                        let pokemonTypesArray = [];

                        for(const element of valor.types){
                            let pokemonTypeImg = document.createElement('img')
                            pokemonTypeImg.classList.add('card-type')
                            let pokemonType = element.type.name;
                            pokemonTypesArray.push(pokemonType);

                            pokemonTypeImg.src="assets/img/pokemon-type-cards/" + pokemonType + ".png";
                            
                            divPokemonCardType.appendChild(pokemonTypeImg)
                        }

                        createTypesStrenghsAndWeakness(pokemonTypesArray, cardPokemon);
                        
                        cardPokemon.querySelector("#stats-altura .stats-value").innerHTML = (valor.height /10) + " m";
                        cardPokemon.querySelector("#stats-peso .stats-value").innerHTML = (valor.weight /10) + " kg";

                        fetch(valor.species.url)
                        .then((resp) => resp.json())
                        .then(function (data) {
                        console.log(data)
                        let descriptions = new Set();
                        cardPokemon.querySelector("#stats-categoria .stats-value").innerHTML = data.genera[7].genus;
                        data.flavor_text_entries.forEach(elemento => {
                            if(elemento.language.name == "en"){
                                 descriptions.add(elemento.flavor_text);
                          }
                        })
                        let entrada = Math.floor(Math.random() * descriptions.size)
                        let descriptionsArray = [...descriptions];
                        cardPokemon.querySelector("#pokemon-description").innerHTML = descriptionsArray[entrada];
                        
                        });

                        createStatsGraph(valor.stats, cardPokemon);
                        
                        let cardability = cardPokemon.querySelector("#stats-habilidade");
                        for(const element of valor.abilities){
                            let pokemonAbility = document.createElement('div');
                            pokemonAbility.classList.add('stats-value');
                            pokemonAbility.innerHTML = captlizeName(element.ability.name);
                            cardability.appendChild(pokemonAbility);                    
                        }



                        

                })
           
           
    }



populatePokemonInformations(pokemonID)

# path
https://localhost:7279/graphql

# Query
## Sõ
query{
  persons{
    id
    name
    location
  }
}

## idõ
query{
  personById (id:1){
    id
    name
    location
  }
}



# Mutation
mutation{
  addPerson (name:"aaa" , location: "Tokyo"){
    id
    name
    location
  }
}

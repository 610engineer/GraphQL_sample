# Query
## ‘SŒŒŸõ
query{
  persons{
    id
    name
    location
  }
}

## idŒŸõ
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

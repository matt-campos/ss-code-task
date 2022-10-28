
# Technical Exercise
Please use this to set up a public repository to share the submission. Treat this as any other project in terms of how you would handle it to meet the requirements including your regular frequency of commits.

## Setup
You'll need Docker on your machine to run the environment you'll be working in easily. Please refer to the `Running with Docker` directions below. A few notes:

* The database connection string will be passed via an environment variable and can be retrieved from the configuration using key `ConnectionStrings:DbContext`.

* In the docker environment we've also provided a SwaggerUI setup to help you bootstrap the use of your API. 

* All tasks can be accomplished by just working in the `AppCode` project.

* You are not required to use this setup and you can modify anything you wish but please provide instructions to easily run your setup if it will not run with the docker setup we've provided.

## Tasks
Please use this project as the base for your work to accomplish the following:

* Please provide an API with which you can accomplish the following

    * Create a user account with the following:
    
        * Name
        
        * Email
        
        * Password
        
    * A user should be able to authenticate with an email and password
        
    * An authenticated user should be able to add and remove their favorite cities where a city consists of the following:
    
        * City name
        
        * Country
        
    * An authenticated user should be able to retrieve a list of their favorite cities

* Please also include 3 tests that cover any aspect of the above.


## Running with Docker
From command line

1. Navigate to the solution folder

2. Run/update docker compose: `docker-compose up -d --build`

3. Once docker compose has been deployed successfully (you'll see it in the output), you can access the service at `http://localhost:8100`. The SwaggerUI can be accessed at `http://localhost:8100/doc/swagger`.


## Important notes
* If you are not able to complete the above, no worries. This is not an all or nothing deal. Please just provide an explanation of what you tried, what worked, what didn't, what you would do in a perfect world.

* We don't expect there to be any issues but, if you run into an error or issue with what we've provided, please note it and complete what you can if you are unable to correct or work around it. 

## Submission
Please provide us with a link to the repository that we'll be able to access. Thanks in advance, we really appreciate it.


# Race Day — Entity Relationship Diagram (ERD)

## 1. Purpose

The Race Day database supports the management of South African road-running, walking and cycling events. It stores user accounts, events, event categories, participant entries and race results.

## 2. Database Entities

### Users
- UserID (Primary Key)
- FullName
- Email
- PasswordHash
- Role
- CreatedAt

### Events
- EventID (Primary Key)
- OrganizerID (Foreign Key → Users.UserID)
- Name
- Description
- EventType
- EventDate
- Location
- RouteInformation
- Status
- CreatedAt

### Categories
- CategoryID (Primary Key)
- EventID (Foreign Key → Events.EventID)
- Name
- DistanceKm
- EntryFee
- Capacity

### Entries
- EntryID (Primary Key)
- ParticipantID (Foreign Key → Users.UserID)
- CategoryID (Foreign Key → Categories.CategoryID)
- EntryDate
- Status

### Results
- ResultID (Primary Key)
- EntryID (Foreign Key → Entries.EntryID)
- FinishTime
- FinishPosition
- ResultStatus

## 3. Relationships

1. One user acting as an organiser can create many events.
2. One event can contain many categories.
3. One participant can have many entries.
4. One category can have many entries.
5. One entry can have zero or one result.
6. Each event, category, entry and result is linked through its foreign keys.

## 4. Business Rules

- Each user must have a unique email address.
- Each event must have an organiser.
- Each category must belong to an existing event.
- A participant cannot register more than once in the same category.
- Entry fees and distances cannot be negative.
- A result must belong to a valid entry.
- An entry may exist before its participant receives a result.

## 5. Design Notes

Weather forecasts will be retrieved from an external weather service when required. Route information will be associated with events. These integrations will be developed according to the requirements of the later project parts.


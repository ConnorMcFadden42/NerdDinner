CREATE TABLE [dbo].[RSVP] (
    [RsvpID]       INT           IDENTITY (1, 1) NOT NULL,
    [DinnerID]     INT           NOT NULL,
    [AttendeeName] NVARCHAR (30) NOT NULL,
    PRIMARY KEY CLUSTERED ([RsvpID] ASC), 
    CONSTRAINT [FK_RSVP_Dinner] FOREIGN KEY (DinnerID) REFERENCES [Dinners]([DinnerID]) 
);


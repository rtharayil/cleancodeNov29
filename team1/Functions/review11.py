## from ..main.badgeBaker import : ot is not specified which module is being imported
## a fix would be
## import ..main.badgeBaker
## return bad_request('Award does not have a name')
## instead we can return a json like 
## jsonify({'error': 'message'})
## The error can be further processed and the message can be disregarded when it is not needed without causing clutter
## awardee.verifyMode='Email ID'
## Replace magic strings like 'Email ID' with constants or enums to avoid potential issues with typos.
## thee are no comments added
## The db.session.commit() appears twice. Consider combining them into a single commit after both operations are completed successfully.
## consider breaking the code into smaller functions
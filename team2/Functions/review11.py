from flask import jsonify, request, g, url_for, current_app
from .. import db
from ..models import Badge, Permission , BadgeTemplate
from . import api
from .decorators import permission_required
from .errors import forbidden ,unauthorized ,bad_request
from  ..main.views import generateUniqueURL
from ..main.badgeBaker import  #did not specify what to import
 
#indentation is not good
 
 
@api.route('/credential', methods=['POST'])
def newCredential(templateID=None): #variable names sometimes camelcase, sometimes snake_case
    #post = Post.from_json(request.json)
 
    name = request.json.get('name')
    if name is None or name == '': #can directly use if not
        return bad_request('Award does not have a name')
 
    templateID = request.json.get('template_ID')
    if templateID is None or templateID == '' : #can directly use if not
        return bad_request('credential templateID  should not be none')    
 
    institution =g.current_user.institution
 
   
 
    badgeTemplate = BadgeTemplate.query.filter_by(institution_id=institution.id,id=templateID).first_or_404()
   
 
    if badgeTemplate.institution == institution : # we can merge these two if statements
        if institution.credit >0 :
 
                uniqueID=generateUniqueURL(name,templateID)
                awardee = Badge(name = name, idName=uniqueID, badgeTemplate_id=badgeTemplate.id)
 
                awardee.email = request.json.get('email')
                awardee.bessage= request.json.get('text')
                awardee.licenseNo =request.json.get('license_number')
                awardee.verifyMode =request.json.get('verify_mode')
                awardee.verifyCode =request.json.get('verify_code') #get all data at once and distribute them later
               
                if awardee.email is not None and awardee.verifyMode is None :
                    awardee.verifyMode='Email ID'
                    awardee.verifyCode=awardee.email
 
                db.session.add(awardee)
                institution.credit = institution.credit-1
                db.session.add(institution)
                db.session.commit()
 
                badgeBaker = Baker()
                badgeBaker.bake(badgeTemplate,awardee)
 
                db.session.commit()
 
                appCtx = current_app._get_current_object()
                return   jsonify({'credential_url': appCtx.config['APP_BASE_URL'] + url_for('main.verify', uniqueID=uniqueID),
        'credential_image': awardee.certLink,
        'credential_name':awardee.name,
        'credential_institution':institution.name,
        'credential_licenseNo':awardee.licenseNo,
        'credential_email':awardee.email,
        'credential_text':awardee.bessage ,
        'credential_dateOfIssue':awardee.date }) #put json data in a separate variable
       
        return bad_request('Insufficient Balance ,Please recharge your account ')
 
    return unauthorized('Insufficient permissions to acess the Requested Credential Template')
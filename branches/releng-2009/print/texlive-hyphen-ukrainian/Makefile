# New ports collection makefile for:	texlive-hyphen-ukrainian
# Date created:		13/03/2010 04:35:09
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	hyphen-ukrainian
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	The hyphen-ukrainian package

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/ukrhyph/ukrhyph.tex:${PORTSDIR}/print/texlive-ukrhyph

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

# New ports collection makefile for:	texlive-vntex
# Date created:		26/01/2009 16:06:39
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	vntex
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Support for Vietnamese.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/plain/plnfss/plnfss.tex:${PORTSDIR}/print/texlive-plnfss

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

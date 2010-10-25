# New ports collection makefile for:	texlive-pkfix-helper
# Date created:		13/03/2010 04:24:21
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	pkfix-helper
PORTVERSION=	20101025
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Make PostScript files accessible to pkfix.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

# New ports collection makefile for:	texlive-bundledoc
# Date created:		04/11/2010 14:10:08
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bundledoc
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Bundle together all the files needed to build a LaTeX document.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

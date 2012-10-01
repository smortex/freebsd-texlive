# New ports collection makefile for:	texlive-installfont
# Date created:		09/21/2010 11:35:53
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	installfont
PORTVERSION=	20120127
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A bash script for installing a LaTeX font family.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

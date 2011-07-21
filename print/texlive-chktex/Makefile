# New ports collection makefile for:	texlive-chktex
# Date created:		09/21/2010 11:35:43
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	chktex
PORTVERSION=	20110721
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Check for errors in LaTeX documents.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>

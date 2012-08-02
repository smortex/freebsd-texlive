# New ports collection makefile for:	texlive-latexpand
# Date created:		08/02/2012 12:20:43
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	latexpand
PORTVERSION=	20120714
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Expand \input and \include in a LaTeX document.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
